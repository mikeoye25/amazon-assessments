namespace AmazonAssessments.Challenges.AttemptTwo
{
    // Q 07: Coding Assessment Demo - Attempt 2 - C 01
    public static class ProcessLogs
    {
        public static List<string> Execute(List<string> logs, int threshold)
        {
            var logsDict = new Dictionary<int, int>();
            foreach (var log in logs)
            {
                var items = log.Split(' ');
                var senderUserId = Convert.ToInt32(items[0]);
                var recipientUserId = Convert.ToInt32(items[1]);
                if (logsDict.ContainsKey(senderUserId))
                {
                    logsDict[senderUserId]++;
                }
                else
                {
                    logsDict.Add(senderUserId, 1);
                }
                if (senderUserId != recipientUserId)
                {
                    if (logsDict.ContainsKey(recipientUserId))
                    {
                        logsDict[recipientUserId]++;
                    }
                    else
                    {
                        logsDict.Add(recipientUserId, 1);
                    }
                }
            }
            var includedUsers = new List<int>();
            foreach (var logDict in logsDict)
            {
                if (logDict.Value >= threshold)
                {
                    includedUsers.Add(logDict.Key);
                }
            }
            includedUsers.Sort();
            var result = new List<string>();
            foreach (var includedUser in includedUsers)
            {
                result.Add(includedUser.ToString());
            }
            return result;
        }
    }
}
