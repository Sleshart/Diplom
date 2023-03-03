using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace HotToWalkToTheLibrary.Class
{
    public class ControlID
    {
        public static int Main_ID { get; set; }
        public static int Books_ID { get; set; }
        public static int Readers_ID { get; set; }
        public static bool ChangeWhat { get; set; }
        public static bool ChangeWhatB { get; set; }
        public static bool ChangeWhatR { get; set; }
        public static string Sql { get; set; }
        public static string SqlB { get; set; }
        public static string SqlR { get; set; }

        public static DispatcherTimer _timer;

        public static string SqlFIOComboBox = "select (cast(Readers_ID as varchar(5)) + ': ' + cast(Sname as varchar(50)) + ' ' + cast(Fname as varchar(50)) + ' ' + cast(Lname as varchar(50))) as FIO from Readers";

        public static string SqlBookComboBox = "select (cast(Books_ID as varchar(5)) + ': \"' + cast(Title as varchar(50)) + '\" ' + cast(Author as varchar(50))) as Books from Books";
    }
}
