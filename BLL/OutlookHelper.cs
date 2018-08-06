using Microsoft.Office.Interop.Outlook;
using System;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace BLL
{
    public class OutlookHelper
    {
        public static void SaveDraft()
        {
            Outlook.Application olApp = new Outlook.Application();
            Outlook.NameSpace olNameSpace = olApp.GetNamespace("MAPI");
            Outlook.MAPIFolder mapiFolderDrafts = (Outlook.MAPIFolder)olNameSpace.GetDefaultFolder(OlDefaultFolders.olFolderDrafts);

            Outlook.MailItem newMail = olApp.CreateItem(OlItemType.olMailItem);
            newMail.Subject = "temat";
            newMail.Body = "treść";
            newMail.Attachments.Add(@"C:\Users\MegaBit\Downloads\drazek1.jpg", Outlook.OlAttachmentType.olByValue, Type.Missing, Type.Missing);

            newMail.Save();            
        }
    }
}
