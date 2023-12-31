using System.Text.Json;
using System.Text.Json.Serialization;

namespace Solomons_initiative_Tracker
{
    public static class JsonFileUtil
    {

        public static void WriteCharacter(CharacterData character)
        {
            SaveFileDialog saveFileDialog = new();

            saveFileDialog.Filter = "Json|*.json";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = character.Name + ".json";

            var options = new JsonSerializerOptions { WriteIndented = true, IncludeFields = true, };
            options.Converters.Add(new JsonStringEnumConverter());

            string path;

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = Path.GetFullPath(saveFileDialog.FileName);

                String JsonString = JsonSerializer.Serialize(character, options);
                File.WriteAllText(path, JsonString);

                MessageBox.Show("Exported " + character.Name + " to file!");
            }
            
        }

        public static CharacterData? GetCharacterData()
        {

            using OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, @"Characters");
            openFileDialog.Filter = "Json files (*.json)|*.json";
            openFileDialog.RestoreDirectory = true;

            var options = new JsonSerializerOptions { WriteIndented = true, IncludeFields = true };

            options.Converters.Add(new JsonStringEnumConverter());

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using StreamReader stream = new(openFileDialog.FileName);
                var fileContent = stream.ReadToEnd();
                CharacterData data = JsonSerializer.Deserialize<CharacterData>(fileContent, options)!;
                return data;

            }

            return null;
        }
    }

}
