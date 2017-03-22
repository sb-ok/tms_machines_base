using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace tms_machines_base
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            using (var dbContext = new MachinesEntities())
            {
                _currentMachine = dbContext.Machines.First();
                _currentMachineChar = _currentMachine.MachineCharacteristic;

                foreach (var m in dbContext.Machines)
                {
                    machinesGrid.Rows.Add(m.MachineID, m.MachineName, m.Model);
                }

                if (machinesGrid.RowCount > 0)
                {
                    machinesGrid.CurrentCell = machinesGrid.Rows[0].Cells[1];
                }
            }

            firmLabel.Text = _currentMachine.MachineName;
            modelLabel.Text = _currentMachine.Model;
            catalogNumberLabel.Text = _currentMachine.CatalogID;
            machineIDLabel.Text = Convert.ToString(_currentMachine.MachineID);
            diametrLabel.Text = Convert.ToString(_currentMachineChar.DiameterMax);
            lengthLabel.Text = Convert.ToString(_currentMachineChar.LengthMax);
            magazinLabel.Text = Convert.ToString(_currentMachineChar.Magazin);
            turretLabel.Text = Convert.ToString(_currentMachineChar.Turret);

            string[] allImagesPath = GetAllImagesPath(_currentMachineChar.Images.Split(new Char[] { ';' }));
            picture1.ImageLocation = allImagesPath[0];
            picture2.ImageLocation = allImagesPath[1];

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void machinesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void machinesGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (machinesGrid.CurrentRow != null)
            {
                var rowID = machinesGrid.CurrentRow.Index;
                var _selectedMachineID = Convert.ToInt32(machinesGrid.Rows[rowID].Cells[0].Value);

                using (var dbContext = new MachinesEntities())
                {

                    foreach (var m in dbContext.Machines)
                    {
                        if (m.MachineID == _selectedMachineID)
                        {
                            _currentMachine = m;
                            _currentMachineChar = m.MachineCharacteristic;
                        }
                    }
                }

                firmLabel.Text = _currentMachine.MachineName;
                modelLabel.Text = _currentMachine.Model;
                catalogNumberLabel.Text = _currentMachine.CatalogID;
                machineIDLabel.Text = Convert.ToString(_currentMachine.MachineID);
                diametrLabel.Text = Convert.ToString(_currentMachineChar.DiameterMax);
                lengthLabel.Text = Convert.ToString(_currentMachineChar.LengthMax);
                magazinLabel.Text = Convert.ToString(_currentMachineChar.Magazin);
                turretLabel.Text = Convert.ToString(_currentMachineChar.Turret);

                string[] allImagesPath = GetAllImagesPath(_currentMachineChar.Images.Split(new Char[] { ';' }));
                picture1.ImageLocation = allImagesPath[0];
                picture2.ImageLocation = allImagesPath[1];
            }
        }

        private void machinesGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private string[] GetAllImagesPath(string[] imagesList)
        {
            string[] imagesFullPath = { "", "" };
            int i = 0;

            foreach (var sin in imagesList)
            {
                imagesFullPath[i] = takePicturesFullAddrese(sin);
                i++;
            }
            return imagesFullPath;
        }

        private string takePicturesFullAddrese(string pictureFileName)
        {
            string[] imagesFullPath = { "", "" };
            string folderPath = Convert.ToString(ConfigurationManager.AppSettings["FileStorageFolderPath"]);
            var fullAddrese = folderPath + pictureFileName;
            return fullAddrese;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        
    }
}
