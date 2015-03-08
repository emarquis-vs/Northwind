using System.Data.Objects;
using System.Runtime.InteropServices;
using System.Data.Entity.Infrastructure;
using System.Collections.Generic;
using System.Data.Metadata.Edm;

namespace Northwind
{
    /// <summary>Entity Data Model base class for any CRUD methods</summary>
    /// <typeparam name="T">Entity Data Model Type</typeparam>
    public class CRUD<T> where T : class, new ()
    {
        // Constructor
        public CRUD ()
        {
            this.edm = new T ();

            if (edm.GetType ().FullName.Split ('.').Length == 3 && edm.GetType ().FullName.Contains (".Model."))
            {
                this.Context = (edm as IObjectContextAdapter).ObjectContext;
                this.EdmTablesList = GetEdmTablesList ();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show (
                                                                                    "The CRUD must be instantiated with an Entity Data Model type :\n\n" +
                                                                                    "CRUD<NorthwindEdm> DataOps = new CRUD<NorthwindEdm>();"
                                                                                    , "Entity Data Model Error"
                                                                                    , System.Windows.Forms.MessageBoxButtons.OK,
                                                                                    System.Windows.Forms.MessageBoxIcon.Error
                                                                                  );
                System.Environment.Exit (0);
            }
        }

        /// <summary>Entity Data Model  (Type defined within the constructor)</summary>
        public T edm { get; private set; }
        /// <summary>Context which holds the Database Context</summary>
        public ObjectContext Context { get; private set; }
        /// <summary>List of all table names included in the Entity Data Model</summary>
        private IList<string> _EdmTablesList = new List<string> ();
        public IList<string> EdmTablesList { get { return _EdmTablesList; } private set { _EdmTablesList = value; } }

        /// <summary>Gets all table names included in the Entity Data Model</summary>
        /// <returns>Entity Data Model table names in a strings list</returns>
        private IList<string> GetEdmTablesList ()
        {
            IList<EntityType> EdmTablesList = this.Context.MetadataWorkspace.GetItems<EntityType> (DataSpace.CSpace);

            IList<string> TableNames = new List<string> ();
            foreach (var Table in EdmTablesList)
                TableNames.Add (Table.Name);

            return TableNames;
        }
    }


    /// <summary>Methods pattern to create database records</summary>
    public interface ICreate
    {
        /// <summary>Creates one a several Records</summary>
        void Create (IList<string[]> DataArray);
    }


    /// <summary>
    /// Methods pattern to read a Data Query and display it into a specific control
    /// </summary>
    /// <typeparam name="ReadT1">Type of returned value from Read() (int, string, Products, etc.)</typeparam>
    /// <typeparam name="ReadT2">Type of Table Column RowId (int, string, Products, etc.)</typeparam>
    /// <typeparam name="DisplayT1">Type of Data Array (int, string, Products, etc.)</typeparam>
    /// <typeparam name="DisplayT2">Type of Control to display the Data Array (Datagrid, ComboBox, etc.)</typeparam>
    public interface IRead<ReadT1, ReadT2, DisplayT1, DisplayT2>
    {
        /// <summary>Returns an Array from a Data Query</summary>
        ReadT1[] Read ([Optional] ReadT2 Id);

        /// <summary>Displays a Data Array into a specific control (Datagrid, ComboBox, etc.)</summary>
        void Display (DisplayT1[] DataArray, DisplayT2 ControlName);
    }


    /// <summary>Methods pattern to update database records</summary>
    /// <typeparam name="T">Fields Collection Type (DataGridViewCellCollection, etc.)</typeparam>
    public interface IUpdate<T>
    {
        /// <summary>Updates all fields of a Record</summary>
        void Update (T RowCells);
    }


    /// <summary>Methods pattern to delete a specific table record</summary>
    public interface IDelete
    {
        /// <summary>Delete one record</summary>
        void Delete (int Id);
    }
}
