using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using WindowsMsg;
using AndroidSms;

namespace SmsConverter
{
  class Program
  {
    static void Main(string[] args)
    {
      if (args.Length < 3)
      {
        Console.WriteLine("usage: smsConverter phoneNumber sms.xml [sms.xml ...] dst.xml");
        return;
      }
      user.PhoneNumber = args[0];
      string dst = args[args.Length - 1];

      //string s_src = "c:\\temp\\sms.xml";
      //string m_src = "c:\\temp\\mms.xml";
      //string dst = "c:\\temp\\sms-20160924181250.xml";
      //user.PhoneNumber = "+17202158615";

      // construct lists to hold converted SMS and MMS objects
      List<ctMms> mms = new List<ctMms>();
      List<ctSms> sms = new List<ctSms>();
      WindowsMsg.ArrayOfMessage msgs;

      // run through source files, processing
      for (int i = 1; i < args.Length - 1; i++) 
      {
        using (var stm = new System.IO.FileStream(args[i], System.IO.FileMode.Open))
        {
          XmlSerializer s = new XmlSerializer(typeof(WindowsMsg.ArrayOfMessage));
          msgs = (WindowsMsg.ArrayOfMessage)s.Deserialize(stm);
        }
        foreach (var msg in msgs.Message) Convert(msg, mms, sms);
      }

      // construct combined message list
      AndroidSms.smses smses = new AndroidSms.smses(mms, sms);
      // and then serialize it out
      using (var stm = new System.IO.FileStream(dst, System.IO.FileMode.Create))
      {
        XmlSerializer s = new XmlSerializer(typeof(AndroidSms.smses));
        s.Serialize(stm, smses);
      }
    }

    /// <summary>
    /// Converts a Windows Phone message into an Android message and adds to message list
    /// </summary>
    /// <param name="msg"></param>
    /// <param name="smses"></param>
    static void Convert(WindowsMsg.ctMessage msg, List<ctMms> mms, List<ctSms> sms)
    {
      // determine if we need an SMS or MMS
      if (msg.Recepients.Length > 1 || msg.Attachments.Length > 0)
        mms.Add(new ctMms(msg));
      else sms.Add(new ctSms(msg));
      return;
    }
  }
}
