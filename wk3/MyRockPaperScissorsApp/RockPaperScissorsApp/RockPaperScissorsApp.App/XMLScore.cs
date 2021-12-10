using System.Xml.Serialization;

namespace RockPaperScissorsApp.App
{
    public class XMLScore
    {
        public string Scores { get; set; } = " ";
        public string FilePath { get; set; } = " ";

        public XMLScore() { }
        
        public XMLScore (string scores, string filePath)
        {
            Scores = scores;
            FilePath = filePath;
        }

        public string ScoresReader()
        {
            XMLScore summery = new XMLScore(Scores, FilePath);
            XmlSerializer reader = new XmlSerializer(typeof(XMLScore));
            summery.Scores = Scores;
            using (StreamReader sr = new StreamReader(FilePath))
            {
                XMLScore? summeryFromFile = reader.Deserialize(sr) as XMLScore;
                sr.Close();
                if (summeryFromFile != null)
                {
                    summery.Scores = summeryFromFile.Scores;
                }
            }
            return summery.Scores;
        }
        public void ScoresWriter()
        {
            XMLScore summery = new XMLScore(Scores, FilePath);
            XmlSerializer writer = new XmlSerializer(typeof(XMLScore));

            try
            {
                using (FileStream fs = File.Create(FilePath))
                {
                    writer.Serialize(fs, summery);
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
