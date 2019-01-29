using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;


namespace WebApplication3
{
    public class Presenter1
    {
        IView _pView;
        IModel _pModel;

        public Presenter1(IView PView, IModel PModel)
        {
            _pView = PView;
            _pModel = PModel;
        }
        public void BindModalView()
        {
            List<String> ls;

            ls = _pModel.setInfo(_pView.TextforWordRev, "reverse");
            _pView.TextBoxRevWord = //"Reverse chracters in the string: " + _pView.TextforWordRev + ": " + 
                ls[0];
            
        }

        public void BindModalViewForReverseString()
        {
            List<String> ls;
            ls = _pModel.setInfo(_pView.TextEnterSentence, "StringCharReverse");
            _pView.TextReverseSentence = //"Reverse chracters in the string: " +_pView.TextEnterSentence + ": " + 
                ls[0];

            List<String> ls1;
            ls1 = _pModel.setInfo(_pView.TextEnterSentence, "StringReverse");
            _pView.TextStringReverse = ls1[0];


            List<String> ls2;
            ls2 = _pModel.setInfo(_pView.TextEnterSentence, "StringReverseWithRevChar");
            _pView.TextStringReverseWithCharRev = ls2[0];
        }
    }
}