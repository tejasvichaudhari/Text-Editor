<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Words and sentence Reverse</title>
    <%--<script src="http://code.jquery.com/jquery-1.10.1.min.js"></script>--%>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
     <script>
         $(function () {
             $('#txtWord').keyup(function () {
                 var txtlen = $(this).val().length;
                 $('#txtCountCharcWord').text(txtlen);
             });
         });

            $(function () {
                $('#txtEnterSentence').keyup(function () {
                    var txtlen = $(this).val().length;
                    $('#txtCountCharacSen').text(txtlen);
                });
            });
        </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
           <table width="90%">
               <tr>
                   <td>
                       <asp:Label ID="lblWord" runat="server" Text="Enter Word:"></asp:Label> &nbsp;
                   </td>
                   <td>
                       <asp:TextBox ID="txtWord" Width="90%" MaxLength="100" runat="server"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="rfvtxtWord" runat="server" ForeColor="Red" 
                           ControlToValidate="txtWord"  ValidationGroup="Word"
                            ErrorMessage="Please enter a word"></asp:RequiredFieldValidator>

                       <p>No. of characters with space : <span id="txtCountCharcWord"></span></p>
                   </td>
                   <td>
                      <asp:Button ID="btnGetReverseWord" runat="server" ValidationGroup="Word" 
                           Text="Get Reverse" onclick="btnGetReverseWord_Click" />
                   </td>
               </tr>
               <tr>
                   <td>
                   </td>
                   <td colspan="2">
                       <%--<asp:Label ID="lblEvenNumbers" runat="server" Text=""></asp:Label> &nbsp;--%>
                       <asp:TextBox ID="txtRevWord" Height="100px" Width="100%" ReadOnly="true" TextMode="MultiLine" runat="server"></asp:TextBox>
                   </td>
               </tr>
           <tr><td colspan="3">&nbsp;</td></tr>
               <tr><td colspan="3">&nbsp;</td></tr>
               <tr><td colspan="3">&nbsp;</td></tr>
               <tr>
                   <td>
                       <asp:Label ID="lblEnterSentence" runat="server" Text="Enter a Sentence:"></asp:Label> &nbsp;
                   </td>
                   <td>
                       <asp:TextBox ID="txtEnterSentence" Width="90%" MaxLength="100"  runat="server"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="rfvtxtEnterSentence" runat="server" ForeColor="Red"
                            ControlToValidate="txtEnterSentence"  ValidationGroup="Sentence"
                            ErrorMessage="Please enter a Sentence"></asp:RequiredFieldValidator>

                       <p>No. of characters with space : <span id="txtCountCharacSen"></span></p>
                   </td>
                   <td>
                        <asp:Button ID="btnReverseSentence" runat="server" ValidationGroup="Sentence" 
                           Text="Get Reverse" onclick="btnReverseSentence_Click" />
                   </td>
               </tr>
               <tr>
                   <td></td>
                   <td colspan="2">
                       <asp:TextBox ID="txtReverseSentence" Height="50px" Width="100%" ReadOnly="true" TextMode="MultiLine" runat="server"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td></td>
                   <td colspan="2">
                       <asp:TextBox ID="txtStringReverse"  Height="50px" Width="100%" ReadOnly="true" TextMode="MultiLine" runat="server"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td></td>
                   <td colspan="2">
                       <asp:TextBox ID="txtStringReverseWithCharRev" Height="50px" Width="100%" ReadOnly="true" TextMode="MultiLine" runat="server"></asp:TextBox>
                   </td>
               </tr>
           </table>
    </div>
        
    </form>
</body>
</html>
