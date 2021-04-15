using System;
using System.IO;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Telegram_Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string token = System.IO.File.ReadAllText("token.txt");
                TelegramBotClient bot = new TelegramBotClient(token);
                int lastMessageId = Convert.ToInt32(System.IO.File.ReadAllText("lastMessageId.txt"));
                Random random = new Random();

                while (true)
                {
                    Update[] lastUpdate = bot.GetUpdatesAsync().Result;

                    if (lastUpdate.Length - 1 < 0)
                    {
                        continue;
                    }

                    int lastUpdateMessageId = lastUpdate[lastUpdate.Length - 1].Message.MessageId;

                    if (lastUpdateMessageId != lastMessageId)
                    {
                        string lastUpdateMessageFromId = Convert.ToString(lastUpdate[lastUpdate.Length - 1].Message.From.Id);
                        string lastUpdateMessageText = lastUpdate[lastUpdate.Length - 1].Message.Text;
                        byte k = Convert.ToByte(random.Next(20));

                        if (k == 0)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "It is certain");
                        }
                        else if (k == 1)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "It is decidedly so");
                        }
                        else if (k == 2)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "Without a doubt");
                        }
                        else if (k == 3)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "Yes — definitely");
                        }
                        else if (k == 4)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "You may rely on it");
                        }
                        else if (k == 5)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "As I see it, yes");
                        }
                        else if (k == 6)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "Most likely");
                        }
                        else if (k == 7)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "Outlook good");
                        }
                        else if (k == 8)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "Signs point to yes");
                        }
                        else if (k == 9)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "Yes");
                        }
                        else if (k == 10)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "Reply hazy, try again");
                        }
                        else if (k == 11)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "Ask again later");
                        }
                        else if (k == 12)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "Better not tell you now");
                        }
                        else if (k == 13)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "Cannot predict now");
                        }
                        else if (k == 14)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "Concentrate and ask again");
                        }
                        else if (k == 15)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "Don’t count on it");
                        }
                        else if (k == 16)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "My reply is no");
                        }
                        else if (k == 17)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "My sources say no");
                        }
                        else if (k == 18)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "Outlook not so good");
                        }
                        else if (k == 19)
                        {
                            bot.SendTextMessageAsync(lastUpdateMessageFromId, "Very doubtful");
                        }

                        lastMessageId = lastUpdateMessageId;
                        System.IO.File.WriteAllText("lastMessageId.txt", Convert.ToString(lastMessageId));
                        Console.WriteLine("\nUser: " + lastUpdate[lastUpdate.Length - 1].Message.From.Username + " (id " + lastUpdateMessageFromId + ")");
                        Console.WriteLine("Message: " + lastUpdateMessageText + "\n________________________________________");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                try
                {
                    System.IO.File.Create("lastMessageId.txt").Close();
                    System.IO.File.WriteAllText("lastMessageId.txt", "0");
                    System.IO.File.Create("token.txt").Close();
                    Console.Write("Please, enter your token: ");
                    string token = Console.ReadLine();
                    TelegramBotClient bot = new TelegramBotClient(token);
                    System.IO.File.WriteAllText("token.txt", token);
                    int lastMessageId = Convert.ToInt32(System.IO.File.ReadAllText("lastMessageId.txt"));
                    Random random = new Random();

                    while (true)
                    {
                        Update[] lastUpdate = bot.GetUpdatesAsync().Result;

                        if (lastUpdate.Length - 1 < 0)
                        {
                            continue;
                        }

                        int lastUpdateMessageId = lastUpdate[lastUpdate.Length - 1].Message.MessageId;

                        if (lastUpdateMessageId != lastMessageId)
                        {
                            string lastUpdateMessageFromId = Convert.ToString(lastUpdate[lastUpdate.Length - 1].Message.From.Id);
                            string lastUpdateMessageText = lastUpdate[lastUpdate.Length - 1].Message.Text;
                            byte k = Convert.ToByte(random.Next(20));

                            if (k == 0)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "It is certain");
                            }
                            else if (k == 1)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "It is decidedly so");
                            }
                            else if (k == 2)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Without a doubt");
                            }
                            else if (k == 3)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Yes — definitely");
                            }
                            else if (k == 4)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "You may rely on it");
                            }
                            else if (k == 5)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "As I see it, yes");
                            }
                            else if (k == 6)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Most likely");
                            }
                            else if (k == 7)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Outlook good");
                            }
                            else if (k == 8)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Signs point to yes");
                            }
                            else if (k == 9)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Yes");
                            }
                            else if (k == 10)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Reply hazy, try again");
                            }
                            else if (k == 11)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Ask again later");
                            }
                            else if (k == 12)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Better not tell you now");
                            }
                            else if (k == 13)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Cannot predict now");
                            }
                            else if (k == 14)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Concentrate and ask again");
                            }
                            else if (k == 15)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Don’t count on it");
                            }
                            else if (k == 16)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "My reply is no");
                            }
                            else if (k == 17)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "My sources say no");
                            }
                            else if (k == 18)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Outlook not so good");
                            }
                            else if (k == 19)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Very doubtful");
                            }

                            lastMessageId = lastUpdateMessageId;
                            System.IO.File.WriteAllText("lastMessageId.txt", Convert.ToString(lastMessageId));
                            Console.WriteLine("\nUser: " + lastUpdate[lastUpdate.Length - 1].Message.From.Username + " (id " + lastUpdateMessageFromId + ")");
                            Console.WriteLine("Message: " + lastUpdateMessageText + "\n________________________________________");
                        }
                    }
                }
                catch (ArgumentException)
                {
                    string token = "";

                    while (token.ToCharArray().Length != 45 || token.ToCharArray()[9] != ':')
                    {
                        Console.WriteLine("Invalid token!");
                        Console.Write("Please, enter your token again: ");
                        token = Console.ReadLine();
                    }

                    TelegramBotClient bot = new TelegramBotClient(token);
                    System.IO.File.WriteAllText("token.txt", token);
                    int lastMessageId = Convert.ToInt32(System.IO.File.ReadAllText("lastMessageId.txt"));
                    Random random = new Random();

                    while (true)
                    {
                        Update[] lastUpdate = bot.GetUpdatesAsync().Result;

                        if (lastUpdate.Length - 1 < 0)
                        {
                            continue;
                        }

                        int lastUpdateMessageId = lastUpdate[lastUpdate.Length - 1].Message.MessageId;

                        if (lastUpdateMessageId != lastMessageId)
                        {
                            string lastUpdateMessageFromId = Convert.ToString(lastUpdate[lastUpdate.Length - 1].Message.From.Id);
                            string lastUpdateMessageText = lastUpdate[lastUpdate.Length - 1].Message.Text;
                            byte k = Convert.ToByte(random.Next(20));

                            if (k == 0)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "It is certain");
                            }
                            else if (k == 1)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "It is decidedly so");
                            }
                            else if (k == 2)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Without a doubt");
                            }
                            else if (k == 3)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Yes — definitely");
                            }
                            else if (k == 4)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "You may rely on it");
                            }
                            else if (k == 5)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "As I see it, yes");
                            }
                            else if (k == 6)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Most likely");
                            }
                            else if (k == 7)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Outlook good");
                            }
                            else if (k == 8)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Signs point to yes");
                            }
                            else if (k == 9)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Yes");
                            }
                            else if (k == 10)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Reply hazy, try again");
                            }
                            else if (k == 11)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Ask again later");
                            }
                            else if (k == 12)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Better not tell you now");
                            }
                            else if (k == 13)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Cannot predict now");
                            }
                            else if (k == 14)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Concentrate and ask again");
                            }
                            else if (k == 15)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Don’t count on it");
                            }
                            else if (k == 16)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "My reply is no");
                            }
                            else if (k == 17)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "My sources say no");
                            }
                            else if (k == 18)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Outlook not so good");
                            }
                            else if (k == 19)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Very doubtful");
                            }

                            lastMessageId = lastUpdateMessageId;
                            System.IO.File.WriteAllText("lastMessageId.txt", Convert.ToString(lastMessageId));
                            Console.WriteLine("\nUser: " + lastUpdate[lastUpdate.Length - 1].Message.From.Username + " (id " + lastUpdateMessageFromId + ")");
                            Console.WriteLine("Message: " + lastUpdateMessageText + "\n________________________________________");
                        }
                    }
                }
            }
            catch (ArgumentException)
            {
                try
                {
                    Console.Write("Please, enter your token: ");
                    string token = Console.ReadLine();
                    TelegramBotClient bot = new TelegramBotClient(token);
                    System.IO.File.WriteAllText("token.txt", token);
                    int lastMessageId = Convert.ToInt32(System.IO.File.ReadAllText("lastMessageId.txt"));
                    Random random = new Random();

                    while (true)
                    {
                        Update[] lastUpdate = bot.GetUpdatesAsync().Result;

                        if (lastUpdate.Length - 1 < 0)
                        {
                            continue;
                        }

                        int lastUpdateMessageId = lastUpdate[lastUpdate.Length - 1].Message.MessageId;

                        if (lastUpdateMessageId != lastMessageId)
                        {
                            string lastUpdateMessageFromId = Convert.ToString(lastUpdate[lastUpdate.Length - 1].Message.From.Id);
                            string lastUpdateMessageText = lastUpdate[lastUpdate.Length - 1].Message.Text;
                            byte k = Convert.ToByte(random.Next(20));

                            if (k == 0)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "It is certain");
                            }
                            else if (k == 1)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "It is decidedly so");
                            }
                            else if (k == 2)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Without a doubt");
                            }
                            else if (k == 3)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Yes — definitely");
                            }
                            else if (k == 4)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "You may rely on it");
                            }
                            else if (k == 5)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "As I see it, yes");
                            }
                            else if (k == 6)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Most likely");
                            }
                            else if (k == 7)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Outlook good");
                            }
                            else if (k == 8)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Signs point to yes");
                            }
                            else if (k == 9)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Yes");
                            }
                            else if (k == 10)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Reply hazy, try again");
                            }
                            else if (k == 11)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Ask again later");
                            }
                            else if (k == 12)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Better not tell you now");
                            }
                            else if (k == 13)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Cannot predict now");
                            }
                            else if (k == 14)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Concentrate and ask again");
                            }
                            else if (k == 15)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Don’t count on it");
                            }
                            else if (k == 16)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "My reply is no");
                            }
                            else if (k == 17)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "My sources say no");
                            }
                            else if (k == 18)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Outlook not so good");
                            }
                            else if (k == 19)
                            {
                                bot.SendTextMessageAsync(lastUpdateMessageFromId, "Very doubtful");
                            }

                            lastMessageId = lastUpdateMessageId;
                            System.IO.File.WriteAllText("lastMessageId.txt", Convert.ToString(lastMessageId));
                            Console.WriteLine("\nUser: " + lastUpdate[lastUpdate.Length - 1].Message.From.Username + " (id " + lastUpdateMessageFromId + ")");
                            Console.WriteLine("Message: " + lastUpdateMessageText + "\n________________________________________");
                        }
                    }
                }
                catch (ArgumentException)
                {
                    try
                    {
                        string token = "";

                        while (token.ToCharArray().Length != 45 || token.ToCharArray()[9] != ':')
                        {
                            Console.WriteLine("Invalid token!");
                            Console.Write("Please, enter your token again: ");
                            token = Console.ReadLine();
                        }

                        TelegramBotClient bot = new TelegramBotClient(token);
                        System.IO.File.WriteAllText("token.txt", token);
                        int lastMessageId = Convert.ToInt32(System.IO.File.ReadAllText("lastMessageId.txt"));
                        Random random = new Random();

                        while (true)
                        {
                            Update[] lastUpdate = bot.GetUpdatesAsync().Result;

                            if (lastUpdate.Length - 1 < 0)
                            {
                                continue;
                            }

                            int lastUpdateMessageId = lastUpdate[lastUpdate.Length - 1].Message.MessageId;

                            if (lastUpdateMessageId != lastMessageId)
                            {
                                string lastUpdateMessageFromId = Convert.ToString(lastUpdate[lastUpdate.Length - 1].Message.From.Id);
                                string lastUpdateMessageText = lastUpdate[lastUpdate.Length - 1].Message.Text;
                                byte k = Convert.ToByte(random.Next(20));

                                if (k == 0)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "It is certain");
                                }
                                else if (k == 1)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "It is decidedly so");
                                }
                                else if (k == 2)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Without a doubt");
                                }
                                else if (k == 3)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Yes — definitely");
                                }
                                else if (k == 4)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "You may rely on it");
                                }
                                else if (k == 5)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "As I see it, yes");
                                }
                                else if (k == 6)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Most likely");
                                }
                                else if (k == 7)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Outlook good");
                                }
                                else if (k == 8)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Signs point to yes");
                                }
                                else if (k == 9)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Yes");
                                }
                                else if (k == 10)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Reply hazy, try again");
                                }
                                else if (k == 11)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Ask again later");
                                }
                                else if (k == 12)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Better not tell you now");
                                }
                                else if (k == 13)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Cannot predict now");
                                }
                                else if (k == 14)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Concentrate and ask again");
                                }
                                else if (k == 15)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Don’t count on it");
                                }
                                else if (k == 16)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "My reply is no");
                                }
                                else if (k == 17)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "My sources say no");
                                }
                                else if (k == 18)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Outlook not so good");
                                }
                                else if (k == 19)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Very doubtful");
                                }

                                lastMessageId = lastUpdateMessageId;
                                System.IO.File.WriteAllText("lastMessageId.txt", Convert.ToString(lastMessageId));
                                Console.WriteLine("\nUser: " + lastUpdate[lastUpdate.Length - 1].Message.From.Username + " (id " + lastUpdateMessageFromId + ")");
                                Console.WriteLine("Message: " + lastUpdateMessageText + "\n________________________________________");
                            }
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        System.IO.File.Create("lastMessageId.txt").Close();
                        System.IO.File.WriteAllText("lastMessageId.txt", "0");
                        string token = System.IO.File.ReadAllText("token.txt");
                        TelegramBotClient bot = new TelegramBotClient(token);
                        int lastMessageId = Convert.ToInt32(System.IO.File.ReadAllText("lastMessageId.txt"));
                        Random random = new Random();

                        while (true)
                        {
                            Update[] lastUpdate = bot.GetUpdatesAsync().Result;

                            if (lastUpdate.Length - 1 < 0)
                            {
                                continue;
                            }

                            int lastUpdateMessageId = lastUpdate[lastUpdate.Length - 1].Message.MessageId;

                            if (lastUpdateMessageId != lastMessageId)
                            {
                                string lastUpdateMessageFromId = Convert.ToString(lastUpdate[lastUpdate.Length - 1].Message.From.Id);
                                string lastUpdateMessageText = lastUpdate[lastUpdate.Length - 1].Message.Text;
                                byte k = Convert.ToByte(random.Next(20));

                                if (k == 0)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "It is certain");
                                }
                                else if (k == 1)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "It is decidedly so");
                                }
                                else if (k == 2)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Without a doubt");
                                }
                                else if (k == 3)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Yes — definitely");
                                }
                                else if (k == 4)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "You may rely on it");
                                }
                                else if (k == 5)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "As I see it, yes");
                                }
                                else if (k == 6)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Most likely");
                                }
                                else if (k == 7)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Outlook good");
                                }
                                else if (k == 8)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Signs point to yes");
                                }
                                else if (k == 9)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Yes");
                                }
                                else if (k == 10)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Reply hazy, try again");
                                }
                                else if (k == 11)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Ask again later");
                                }
                                else if (k == 12)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Better not tell you now");
                                }
                                else if (k == 13)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Cannot predict now");
                                }
                                else if (k == 14)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Concentrate and ask again");
                                }
                                else if (k == 15)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Don’t count on it");
                                }
                                else if (k == 16)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "My reply is no");
                                }
                                else if (k == 17)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "My sources say no");
                                }
                                else if (k == 18)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Outlook not so good");
                                }
                                else if (k == 19)
                                {
                                    bot.SendTextMessageAsync(lastUpdateMessageFromId, "Very doubtful");
                                }

                                lastMessageId = lastUpdateMessageId;
                                System.IO.File.WriteAllText("lastMessageId.txt", Convert.ToString(lastMessageId));
                                Console.WriteLine("\nUser: " + lastUpdate[lastUpdate.Length - 1].Message.From.Username + " (id " + lastUpdateMessageFromId + ")");
                                Console.WriteLine("Message: " + lastUpdateMessageText + "\n________________________________________");
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        FunctionFormatException();
                    }
                }
                catch (FormatException)
                {
                    FunctionFormatException();
                }
            }
            catch (FormatException)
            {
                FunctionFormatException();
            }
            finally
            {
                Console.ReadKey();
            }
        }

        public static void FunctionFormatException()
        {
            System.IO.File.WriteAllText("lastMessageId.txt", "0");
            string token = System.IO.File.ReadAllText("token.txt");
            TelegramBotClient bot = new TelegramBotClient(token);
            int lastMessageId = Convert.ToInt32(System.IO.File.ReadAllText("lastMessageId.txt"));
            Random random = new Random();

            while (true)
            {
                Update[] lastUpdate = bot.GetUpdatesAsync().Result;

                if (lastUpdate.Length - 1 < 0)
                {
                    continue;
                }

                int lastUpdateMessageId = lastUpdate[lastUpdate.Length - 1].Message.MessageId;

                if (lastUpdateMessageId != lastMessageId)
                {
                    string lastUpdateMessageFromId = Convert.ToString(lastUpdate[lastUpdate.Length - 1].Message.From.Id);
                    string lastUpdateMessageText = lastUpdate[lastUpdate.Length - 1].Message.Text;
                    byte k = Convert.ToByte(random.Next(20));

                    if (k == 0)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "It is certain");
                    }
                    else if (k == 1)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "It is decidedly so");
                    }
                    else if (k == 2)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "Without a doubt");
                    }
                    else if (k == 3)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "Yes — definitely");
                    }
                    else if (k == 4)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "You may rely on it");
                    }
                    else if (k == 5)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "As I see it, yes");
                    }
                    else if (k == 6)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "Most likely");
                    }
                    else if (k == 7)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "Outlook good");
                    }
                    else if (k == 8)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "Signs point to yes");
                    }
                    else if (k == 9)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "Yes");
                    }
                    else if (k == 10)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "Reply hazy, try again");
                    }
                    else if (k == 11)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "Ask again later");
                    }
                    else if (k == 12)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "Better not tell you now");
                    }
                    else if (k == 13)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "Cannot predict now");
                    }
                    else if (k == 14)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "Concentrate and ask again");
                    }
                    else if (k == 15)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "Don’t count on it");
                    }
                    else if (k == 16)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "My reply is no");
                    }
                    else if (k == 17)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "My sources say no");
                    }
                    else if (k == 18)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "Outlook not so good");
                    }
                    else if (k == 19)
                    {
                        bot.SendTextMessageAsync(lastUpdateMessageFromId, "Very doubtful");
                    }

                    lastMessageId = lastUpdateMessageId;
                    System.IO.File.WriteAllText("lastMessageId.txt", Convert.ToString(lastMessageId));
                    Console.WriteLine("\nUser: " + lastUpdate[lastUpdate.Length - 1].Message.From.Username + " (id " + lastUpdateMessageFromId + ")");
                    Console.WriteLine("Message: " + lastUpdateMessageText + "\n________________________________________");
                }
            }
        }
    }
}
