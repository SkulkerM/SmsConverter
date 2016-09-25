using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidSms
{
  public class UnixTime
  {
    public static long ConvertFileTime(long ftime)
    {
      var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Ticks;
      return (DateTime.FromFileTimeUtc(ftime).Ticks - unixEpoch) / 10000L;
    }

    public static long Now()
    {
      var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Ticks;
      return (DateTime.UtcNow.Ticks - unixEpoch) / 10000L;
    }
  }

  public partial class smses
  {
    public smses()
    {
      count = 0;
      backup_set = Guid.NewGuid().ToString();
      backup_date = UnixTime.Now();
    }

    public smses(List<ctMms> _mms, List<ctSms> _sms) 
      : this()
    {
      count = _mms.Count + _sms.Count;
      mms = _mms.ToArray();
      sms = _sms.ToArray();
    }
  }

  public partial class ctPart
  {
    public ctPart()
    {
      name = "null";
      cd = "null";
      fn = "null";
      ctt_s = "null";
      ctt_t = "null";
    }

    public ctPart(int _seq, string _ct, int _chset, string _cid, string _cl, string _text, string _data)
    {
      seq = _seq;
      ct = _ct;
      chset = _chset;
      cid = _cid;
      cl = _cl;
      text = _text;
      data = _data;
    }
  }

  public partial class ctAddr
  {
    public ctAddr()
    {
      charset = 106;
    }

    public ctAddr(string _address, int _type)
      : this()
    {
      address = _address;
      type = _type;
    }
  }

  public partial class ctSms
  {
    public ctSms()
    {
      protocol = 0;
      subject = "null";
      toa = "null";
      sc_toa = "null";
      service_center = "null";
      read = 1;
      status = -1;
      locked = 0;
      date_sent = ((long)(0));
      contact_name = "(Unknown)";
      readable_date = "null";
    }

    public ctSms(WindowsMsg.ctMessage msg) 
      : this()
    {
      body = msg.Body;
      // did someone send this to us?
      if (msg.Recepients.Length <= 0) 
      {
        address = msg.Sender;
        type = 1;
      }
      else 
      {
        address = msg.Recepients[0];
        type = 2;
      }
      date = UnixTime.ConvertFileTime(msg.LocalTimestamp);
      readable_date = DateTime.FromFileTime(msg.LocalTimestamp).ToString();
    }
  }

  public partial class ctMms
  {
    public ctMms()
    {
      using_mode = 0;
      msg_box = 1;
      secret_mode = 0;
      v = 16;
      ct_cls = "null";
      retr_txt_cs = "null";
      d_rpt_st = 0;
      favorite = 0;
      deletable = 0;
      sim_imsi = "null";
      st = "null";
      creator = "com.samsung.android.communicationservice";
      tr_id = "null";
      sim_slot = 0;
      read = 1;
      callback_set = 0;
      m_type = 132;
      locked = 0;
      retr_txt = "null";
      resp_txt = "null";
      rr_st = 0;
      safe_message = 0;
      retr_st = "null";
      reserved = 0;
      msg_id = 0;
      hidden = 0;
      sub = "null";
      seen = 1;
      rr = 129;
      ct_l = "null";
      from_address = "null";
      exp = "null";
      sub_cs = "null";
      sub_id = -1;
      app_id = 0;
      resp_st = "null";
      date_sent = 0;
      pri = 129;
      d_rpt = 129;
      d_tm = "null";
      read_status = "null";
      device_name = "null";
      spam_report = 0;
      rpt_a = "null";
      m_cls = "null";
      contact_name = "(Unknown)";
      m_id = Guid.NewGuid().ToString();
    }

    public ctMms(WindowsMsg.ctMessage msg)
      : this()
    {
      bool sending;

      date = UnixTime.ConvertFileTime(msg.LocalTimestamp);
      readable_date = DateTime.FromFileTime(msg.LocalTimestamp).ToString();

      // if we are sending
      if (msg.Sender == null || msg.Sender.Length < 1)
      {
        sending = true;
        v = 18;
        msg_box = 2;
        m_type = 128;
      }
      else 
      {
        sending = false;
        v = 16;
        msg_box = 1;
        m_type = 132;
      }


      // address is concatenation of recipients separated by a tilde, not including us
      // like: address="+17209856926~+13039316052"
      List<string> lst = new List<string>();
      if (!sending) lst.Add(msg.Sender);
      foreach (var rcp in msg.Recepients) lst.Add(rcp);
      lst.Sort();
      foreach (var rcp in lst)
      {
        if (address != null && address.Length > 0) address += "~";
        address += rcp;
      }

      List<ctAddr> laddr = new List<ctAddr>();
      // add the sender of the message
      if (sending) 
      {
        laddr.Add(new AndroidSms.ctAddr(SmsConverter.user.PhoneNumber, 137));
      }
      else 
      {
        laddr.Add(new AndroidSms.ctAddr(msg.Sender, 137));
        laddr.Add(new AndroidSms.ctAddr(SmsConverter.user.PhoneNumber, 151));
      }
      // add the remaining receivers
      foreach (var rc in msg.Recepients)
      {
        laddr.Add(new AndroidSms.ctAddr(rc, 151));
      }
      addrs = laddr.ToArray();

      List<ctPart> lpart = new List<ctPart>();
      // assume text only to start
      text_only = 1;
      int id = 0;
      ct_t = "application/vnd.wap.multipart.mixed";
      // run through attachments
      foreach (var att in msg.Attachments)
      {
        string cl;
        string text = null;
        string data = null;

        if (att.AttachmentContentType == "application/smil")
        {
          ct_t = "application/vnd.wap.multipart.related";
          cl = "smil.smil";
          text = Encoding.Unicode.GetString(Convert.FromBase64String(att.AttachmentDataBase64String));
        }
        else if (att.AttachmentContentType == "text/plain")
        {
          cl = "text_" + id + ".txt"; id++;
          text = Encoding.Unicode.GetString(Convert.FromBase64String(att.AttachmentDataBase64String));
        }
        else if (att.AttachmentContentType == "image/jpeg")
        {
          cl = "image_" + id + ".jpg"; id++; 
          data = att.AttachmentDataBase64String;
          text_only = 0;
        }
        else if (att.AttachmentContentType == "image/png")
        {
          cl = "image_" + id + ".png"; id++; 
          data = att.AttachmentDataBase64String;
          text_only = 0;
        }
        else if (att.AttachmentContentType == "image/gif")
        {
          cl = "image_" + id + ".gif"; id++;
          data = att.AttachmentDataBase64String;
          text_only = 0;
        }
        else if (att.AttachmentContentType == "video/mp4")
        {
          cl = "video_" + id + ".mp4"; id++;
          data = att.AttachmentDataBase64String;
          text_only = 0;
        }
        else if (att.AttachmentContentType == "video/3gpp")
        {
          cl = "video_" + id + ".3gp"; id++;
          data = att.AttachmentDataBase64String;
          text_only = 0;
        }
        else if (att.AttachmentContentType == "text/vcard" ||
                 att.AttachmentContentType == "text/x-vCard")
        {
          cl = "vcard_" + id + ".vcf"; id++;
          data = att.AttachmentDataBase64String;
          text_only = 0;
        }
        else if (att.AttachmentContentType == "audio/amr")
        {
          cl = "audio_" + id + ".3ga"; id++;
          data = att.AttachmentDataBase64String;
          text_only = 0;
        }
        else throw new System.Exception("Can't handle this type: " + att.AttachmentContentType);

        lpart.Add(new ctPart((cl == "smil.smil") ? -1 : 0, att.AttachmentContentType, 106, "<" + cl + ">", cl, text, data)); 
      }
      lpart.Sort((a, b) => a.seq - b.seq);
      parts = lpart.ToArray();
    }
  }
}