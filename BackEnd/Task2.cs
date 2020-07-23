using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public class Task2
    {
        private const string LikesThis = "likes this";
        private const string LikeThis = "like this";
        public string ViewLikes(List<string> names)
        {
            var count = 0;

            string whoLiked = string.Empty;

            var totalNumberOfLikes = names.Count;

            if (totalNumberOfLikes == 0)
                return $"no one {LikesThis}";

            foreach (var name in names)
            {

                if (totalNumberOfLikes >= 4 && count > 1)
                {
                    whoLiked = whoLiked.TrimEnd(',');

                    return $"{whoLiked} and {totalNumberOfLikes - 2} others {LikeThis}";
                }


                if (totalNumberOfLikes >= 1)
                {
                    count++;

                    if (count < totalNumberOfLikes)
                    {
                        whoLiked += string.IsNullOrWhiteSpace(whoLiked) ? $"{name}," : $" {name},";
                    }
                    else
                    {
                        whoLiked = whoLiked.TrimEnd(',');
                        whoLiked += totalNumberOfLikes == 1 ? name : $" and {name}";
                    }
                }
                
            }

            whoLiked += totalNumberOfLikes > 1 ? $" {LikeThis}" : $" {LikesThis}";

            return whoLiked;
        }
    }
}
