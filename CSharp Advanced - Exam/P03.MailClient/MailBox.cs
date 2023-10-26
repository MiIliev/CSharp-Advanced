using System.Collections;
using System.Text;

namespace MailClient
{
    public class MailBox : IEnumerable<Mail>
    {
        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }

        public int Capacity { get; set; }
        public List<Mail> Inbox { get; set; }
        public List<Mail> Archive { get; set; }

        public void IncomingMail(Mail mail)
        {
            if (Inbox.Count < Capacity)
            {
                Inbox.Add(mail);
            }
        }

        public bool DeleteMail(string sender)
        {
            Mail mailToDelete = Inbox.FirstOrDefault(mail => mail.Sender == sender);

            if (mailToDelete != null)
            {
                Inbox.Remove(mailToDelete);
                return true;
            }

            return false;
        }

        public int ArchiveInboxMessages()
        {
            int mailsRemoved = 0;
            List<Mail> inboxCopy = new List<Mail>(Inbox);
            foreach(Mail mail in inboxCopy)
            {
                Archive.Add(mail);
                Inbox.Remove(mail);
                mailsRemoved++;
            }
            return mailsRemoved;
        }

        public string GetLongestMessage()
        {
            StringBuilder sb = new StringBuilder();
            Mail longestMail = Inbox
                .OrderByDescending(mail => mail.Body.Length)
                .First();
            sb.Append(longestMail.ToString());
            return sb.ToString();
        }

        public string InboxView()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Inbox:");
            foreach (Mail mail in Inbox)
            {
                sb.AppendLine(mail.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public IEnumerator<Mail> GetEnumerator()
        {
            for (int i = 0; i< Inbox.Count; i++)
            {
                yield return Inbox[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
