using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace WebApplication3
{
    public partial class _Default : System.Web.UI.Page, IView
    {
        protected void Page_Load(object sender, EventArgs e)
       {

        }

        #region IView Members

        public string LabelWord 
        {
            get
            {
                return lblWord.Text;
            }
            set
            {
                lblWord.Text = value;
            }
        }

        public string TextforWordRev
        {
            get
            {
                return txtWord.Text;
            }
            set
            {
                txtWord.Text = value;
            }
        }

        public string TextBoxRevWord
        {
            get
            {
                return txtRevWord.Text;
            }
            set
            {
                txtRevWord.Text = value;
            }
        }

        // Sentence Reverse
        public string LabelEnterSentence
        {
            get
            {
                return lblEnterSentence.Text;
            }
            set
            {
                lblEnterSentence.Text = value;
            }
        }

        public string TextEnterSentence
        {
            get
            {
                return txtEnterSentence.Text;
            }
            set
            {
                txtEnterSentence.Text = value;
            }
        }

        public string TextReverseSentence
        {
            get
            {
                return txtReverseSentence.Text;
            }
            set
            {
                txtReverseSentence.Text = value;
            }
        }

   

        // String Reverse
        public string TextStringReverse
        {
            get
            {
                return txtStringReverse.Text;
            }
            set
            {
                txtStringReverse.Text = value;
            }
        }

        public string TextStringReverseWithCharRev
        {
            get
            {
                return txtStringReverseWithCharRev.Text;
            }
            set
            {
                txtStringReverseWithCharRev.Text = value;
            }
        }
        #endregion

        protected void btnGetReverseWord_Click(object sender, EventArgs e)
        {
            Presenter1 p = new Presenter1(this, new WebApplication3.Model());
            p.BindModalView();
        }

        protected void btnReverseSentence_Click(object sender, EventArgs e)
        {
            Presenter1 p = new Presenter1(this, new WebApplication3.Model());
            p.BindModalViewForReverseString();
        }
    }
}
