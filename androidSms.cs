﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace AndroidSms {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class smses {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sms", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ctSms[] sms;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mms", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ctMms[] mms;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int count;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string backup_set;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long backup_date;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ctSms {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int protocol;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string address;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long date;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string subject;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string body;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string toa;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sc_toa;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string service_center;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int read;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int status;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int locked;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long date_sent;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string readable_date;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contact_name;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ctAddr {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string address;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int charset;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ctPart {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int seq;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ct;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int chset;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cd;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fn;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cid;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cl;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ctt_s;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ctt_t;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string text;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string data;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ctMms {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("part", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ctPart[] parts;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("addr", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ctAddr[] addrs;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int text_only;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ct_t;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int using_mode;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int msg_box;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int secret_mode;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int v;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ct_cls;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string retr_txt_cs;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int d_rpt_st;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int favorite;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int deletable;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sim_imsi;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string st;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string creator;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tr_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sim_slot;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int read;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string m_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int callback_set;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int m_type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int locked;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string retr_txt;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string resp_txt;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int rr_st;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int safe_message;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string retr_st;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int reserved;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int msg_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int hidden;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sub;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int seen;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int rr;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ct_l;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string from_address;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int m_size;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exp;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sub_cs;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sub_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int app_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string resp_st;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long date;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long date_sent;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pri;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string address;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int d_rpt;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string d_tm;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string read_status;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string device_name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int spam_report;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rpt_a;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string m_cls;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string readable_date;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contact_name;
    }
}