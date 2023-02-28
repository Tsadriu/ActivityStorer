using ActivityStorer.Enums;
using TsadriuUtilities;
using TsadriuUtilities.Csv.CsvObjects;
using TsadriuUtilities.Csv.CsvObjects.Enums;

namespace ActivityStorer
{
    internal static class Program
    {
        public static readonly string CurrentDirectory = Path.GetPathRoot(Environment.CurrentDirectory) ?? Directory.GetCurrentDirectory();
        public static readonly string ProgramStorage = Path.Combine(CurrentDirectory, "Activity Storer");
        public static readonly string ActivityStorage = Path.Combine(ProgramStorage, "Activity");
        public static readonly string SettingsStorage = Path.Combine(ProgramStorage, "Settings");
        public static readonly string LineBreak = "§NEW_LINE_BREAK§";
        private static VersionEnum currentVersion = VersionEnum.V1_2_0;
        public static ActivityStorerLauncher launcher = new ActivityStorerLauncher();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            launcher.StartPosition = FormStartPosition.CenterScreen;
            CreateDefaultFolders();
            CheckReadMeFile(true);
            CheckWorkerListSettings();
            Application.Run(launcher);
        }

        /// <summary>
        /// Returns the current version as a string. Note that is removes the V and replaces the _ as a . found in <see cref="VersionEnum"/>.
        /// </summary>
        /// <returns><see cref="currentVersion"/> as "Version x.x.x" (<see cref="VersionEnum.V1_0_0"/> returns Version 1.0.0 and so on).</returns>
        public static string GetVersionAsString()
        {
            return $"Version {currentVersion.ToString().Remove("V").Replace("_", ".")}";
        }

        /// <summary>
        /// Gets the list of workers of the company.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetWorkers()
        {
            string path = Path.Combine(SettingsStorage, "workerList.csv");
            ICsvTable newTable = new CsvTable(File.ReadAllLines(path), ";");
            return newTable["Worker"].RowList;
        }

        private static void CreateDefaultFolders()
        {
            Directory.CreateDirectory(ProgramStorage);
            Directory.CreateDirectory(ActivityStorage);
            Directory.CreateDirectory(SettingsStorage);
        }

        private static void CheckReadMeFile(bool createIfMissing)
        {
            string path = Path.Combine(ProgramStorage, "ReadMe.txt");

            if (File.Exists(path) || !createIfMissing)
            {
                return;
            }

            const string readMeContent = "This folder contains the data of the activities and the workers of a company. Deleting this folder will delete all saved data.";

            File.WriteAllText(path, readMeContent);
        }

        private static void CheckWorkerListSettings()
        {
            string fullFilePath = Path.Combine(SettingsStorage, "workerList.csv");

            if (File.Exists(fullFilePath))
            {
                return;
            }

            Directory.CreateDirectory(SettingsStorage);
            FileStream file = File.Create(fullFilePath);
            file.Close();

            ICsvTable table = new CsvTable("Worker");
            File.WriteAllLines(fullFilePath, table.ToList());
        }
    }
}
