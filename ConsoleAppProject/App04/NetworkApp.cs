using System;
using ConsoleAppProject.Helpers;
namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {

        ///<summary>
        /// This class contains the functionality to run
        /// the app, lists the choices, and contains all
        /// the functions to create a social media App.
        ///</summary>
        /// <author>
        /// Nick Bowley
        /// @version 0.1
        /// </author>

        private NewsFeed news = new NewsFeed();

        private String[] choices =
        {
                "Post Message",
                "Post Image",
                "Display All Posts",
                "Display User's Post",
                "Comment",
                "Like",
                "Unlike",
                "Remove Post",
                "Quit",
        };


        private string user;
        private DateTime startDate;
        private DateTime endDate;
        private string message;
        private string filename;
        private string caption;

        private bool quit;

        /// <summary>
        /// Runs the program, it outputs the
        /// heading all of the options for the user.
        /// </summary>
        public void Run()
        {
            quit = false;
            do
            {
                ConsoleHelper.OutputHeading("Nick Bowley's News Feed");
                int choice = ConsoleHelper.SelectChoice(choices);
                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: DisplayUsersPost(); break;
                    case 5: AddComment(); break;
                    case 6: LikePost(); break;
                    case 7: UnlikePost(); break;
                    case 8: RemovePost(); break;
                    case 9: DisplayTimeRangePost(); break;
                    case 10:quit = true; break;
                }
            } while (!quit);
        }

        /// <summary>
        /// This will allow the user to post a message in text
        /// </summary>
        private void PostMessage()
        {
            ConsoleHelper.OutputTitle(" Adding new message post");
            Console.Write(" Please enter your name > ");
            user = Console.ReadLine();

            Console.Write(" Please enter your message > ");
            message = Console.ReadLine();

            MessagePost messagePost = new MessagePost(user, message);
            news.AddMessagePost(messagePost);

            ConsoleHelper.OutputTitle(" Message Posted!");
        }

        /// <summary>
        /// This method allows the user to post an image
        /// </summary>
        private void PostImage()
        {
            Console.Write(" Please Enter Your Name > ");
            user = Console.ReadLine();

            Console.Write(" Please Enter Your Photo filename > ");
            filename = Console.ReadLine();

            Console.Write(" Please Enter Your Caption > ");
            caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(user, filename, caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OutputTitle(" Photo Posted!");
        }

        /// <summary>
        /// This will display all of the posts
        /// </summary>
        private void DisplayAll()
        {
            ConsoleHelper.OutputTitle(" Displaying all Posts:");
            news.Display();
        }

        /// <summary>
        /// This will allow the user to search for a specific 
        /// users posts.
        /// </summary>
        private void DisplayUsersPost()
        {
            Console.Write(" Please enter a Username > ");
            user = Console.ReadLine();

            ConsoleHelper.OutputTitle($"Displaying {user}'s Post");
            news.DisplayUsersPost(user);
        }

        /// <summary>
        /// This allows the user to add a comment
        /// on any existing post through inputing the ID
        /// </summary>
        private void AddComment()
        {
            int id = (int)ConsoleHelper.InputNumber(" Please enter " +
                "the ID of the Post you wish to Comment on > ");
            Post post = news.FindPost(id);

            if (post != null)
            {

                Console.Write(" Please Enter Your Comment > ");
                string comment = Console.ReadLine();
                post.AddComment(comment);
            }
            else
            {
                Console.WriteLine(" This post cannot be found");
            }

            ConsoleHelper.OutputTitle(" Comment Added");
        }

        /// <summary>
        /// This function allows the user to like
        /// any existing post by inputing the ID
        /// </summary>
        private void LikePost()
        {
            int id = (int)ConsoleHelper.InputNumber(" Please enter " +
                "the ID of the Post you wish to Like > ");
            Post post = news.FindPost(id);

            if (post != null)
            {
                post.Like();
            }
            else
            {
                Console.WriteLine(" This post does not exist");
            }

            ConsoleHelper.OutputTitle(" Post liked!");
        }

        /// <summary>
        /// This function allows the user to unlike
        /// any existing post by inputing the ID
        /// </summary>
        private void UnlikePost()
        {
            int id = (int)ConsoleHelper.InputNumber(" Please enter " +
                "the ID of the Post you wish to Unlike > ");
            Post post = news.FindPost(id);

            post.Unlike();

            ConsoleHelper.OutputTitle(" Post unliked");
        }

        /// <summary>
        /// This function allows the user to remove
        /// any existing post by inputing the ID
        /// </summary>
        private void RemovePost()
        {
            int id = (int)ConsoleHelper.InputNumber(" Please enter " +
                "the ID of the Post you wish to remove > ");
            Post post = news.FindPost(id);

            if (post != null)
            {
                Console.WriteLine($" Removing Post number {post.PostID}");
                news.RemovePost(id);
            }
            else
            {
                Console.WriteLine(" This post can not be found");
            }

            ConsoleHelper.OutputTitle(" Post Removed");
        }

        /// <summary>
        /// This function allows the user to search for
        /// a post with in a time frame the user chooses
        /// </summary>
        private void DisplayTimeRangePost()
        {
            Console.Write(" Please enter a start date > ");
            startDate = DateTime.Parse(Console.ReadLine());

            Console.Write(" Please enter a end date > ");
            endDate = DateTime.Parse(Console.ReadLine());

            ConsoleHelper.OutputTitle($"Displaying {startDate} - {endDate} Post");
            news.DisplayTimeRangePost(startDate, endDate);
        }
    }
}
