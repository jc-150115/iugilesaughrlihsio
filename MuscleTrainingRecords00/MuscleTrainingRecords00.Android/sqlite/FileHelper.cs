using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using System.IO;
using Xamarin.Forms;
using MuscleTrainingRecords00.Droid;
using MuscleTrainingRecords00.Droid.sqlite;
using MuscleTrainingRecords00;
using MuscleTrainingRecords00.sqlite;

[assembly: Dependency(typeof(FileHelper))]

namespace MuscleTrainingRecords00.Droid.sqlite
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}