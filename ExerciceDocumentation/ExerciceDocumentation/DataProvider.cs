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
        /// 
        /// Vous pouvez accéder à toute les données avec une liste de string:
        /// <code>
        ///     foreach (var data in data.GetAllData()
        ///     {
        ///         lstDisplay.Items.Add(data);
        ///     }
        /// </code>
        /// 
        /// ou recevoir une ligne de données directement avec son index.:
        /// <code>
        ///     lstDisplay.Items.Add(data.GetSingleLineOfData(3)
        ///     <param name="indexOfData">L'index de la ligne désirée dans la base de données.</param>
        /// </code>
        /// 
        /// </summary>
        public List<string> DataCollection { get; }

        public SqlConnection Connection { get; }

        public DataProvider(string connectionString)
        {
            Connection.ConnectionString = connectionString;
        }

        public List<string> GetAllData()
        {
            return DataCollection;
        }

        public string GetSingleLineOfData(int indexOfData)
        {
            return DataCollection[indexOfData];
        }
    }
}
