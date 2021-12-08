using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDocumentation
{
    public class DataProvider
    {
        /// <summary>
        /// Cette classe est utilisée dans le contexte d'un exercice pour se pratiquer à créer de la documentation.
        /// 
        /// Le DataProvider permet d'accéder à des données à partir d'une base de données de type SQLServer.
        /// Pour l'initialiser, vous devez avoir en main votre connection string. Vous pouvez initialiser la classe de cette manière:
        /// <code>
        ///     DataProvider data = new DataProvider("connexionAVotreDb");
        /// </code>
        /// </summary>
        public List<string> DataCollection { get; }

        public SqlConnection Connection { get; }

        public DataProvider(string connectionString)
        {
            Connection.ConnectionString = connectionString;
        }
        /// <summary>
        /// Vous pouvez accéder à toute les données avec une liste de string:
        /// <code>
        ///     foreach (var data in data.GetAllData()
        ///     {
        ///         lstDisplay.Items.Add(data);
        ///     }
        /// </code>
        /// </summary>
        /// <returns>Cette fonction retourne toute la base de données sous forme de liste de string.</returns>
        public List<string> GetAllData()
        {
            return DataCollection;
        }
        /// <summary>
        /// Cette fonction sert à itérer une seule ligne de notre base de données. Elle s'appelle de cette façon:
        /// <code> lstDisplay.Items.Add(data.GetSingleLineOfData(3));</code>
        /// </summary>
        /// <param name="indexOfData">L'index de la ligne a itérer.</param>
        /// <returns></returns>
        public string GetSingleLineOfData(int indexOfData)
        {
            return DataCollection[indexOfData];
        }
    }
}
