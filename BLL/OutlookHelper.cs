using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Configuration;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace BLL
{
    public class OutlookHelper
    {
        public static void SaveDraft(List<string> lstAttachments, string emailTo)
        {
            Outlook.Application olApp = new Outlook.Application();
            Outlook.NameSpace olNameSpace = olApp.GetNamespace("MAPI");
            Outlook.MAPIFolder mapiFolderDrafts = (Outlook.MAPIFolder)olNameSpace.GetDefaultFolder(OlDefaultFolders.olFolderDrafts);

            Outlook.MailItem newMail = olApp.CreateItem(OlItemType.olMailItem);
            newMail.Subject = ConfigurationSettings.AppSettings["mail_subject"];
            newMail.HTMLBody = ConfigurationSettings.AppSettings["mail_body"];            
            newMail.To = emailTo;

            foreach (var attachment in lstAttachments)
            {
                newMail.Attachments.Add(attachment, Outlook.OlAttachmentType.olByValue, Type.Missing, Type.Missing);
            }

            newMail.Save();                             
        }
    }
}
