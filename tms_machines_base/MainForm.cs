using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

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

            FillMachineData(_currentMachine, _currentMachineChar);

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

                FillMachineData(_currentMachine, _currentMachineChar);
            }
        }

        private string GetPicturesFullAddrese(string pictureFileName)
        {            
            var fullAddrese = Directory.GetCurrentDirectory() + "\\filestorage\\" +  pictureFileName;
            return fullAddrese;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void FillMachineData(Machine machine, MachineCharacteristic machineCharacteristic)
        {
            firmLabel.Text = machine.MachineName;
            modelLabel.Text = machine.Model;
            catalogNumberLabel.Text = machine.CatalogID;
            machineIDLabel.Text = Convert.ToString(machineCharacteristic.MachineID);
            diametrLabel.Text = Convert.ToString(machineCharacteristic.DiameterMax);
            lengthLabel.Text = Convert.ToString(machineCharacteristic.LengthMax);
            magazinLabel.Text = Convert.ToString(machineCharacteristic.Magazin);
            turretLabel.Text = Convert.ToString(machineCharacteristic.Turret);

            string[] allImagesPath = machineCharacteristic.Images.Split(new Char[] { ';' });
            picture1.ImageLocation = GetPicturesFullAddrese(allImagesPath[0]);
            picture2.ImageLocation = GetPicturesFullAddrese(allImagesPath[1]);
        }

        private void paramMinLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnteredCharForDigits(e);
        }

        private void CheckEnteredCharForDigits( KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void paramMinDiameter_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnteredCharForDigits(e);
        }

        private void paramMaxLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnteredCharForDigits(e);
        }

        private void paramMaxDiametr_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnteredCharForDigits(e);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            using (var dbContext = new MachinesEntities())
            {
                IQueryable<MachineCharacteristic> query = dbContext.MachineCharacteristics;
                if (paramMinDiameter.TextLength > 0)
                {
                    var minDiam = Convert.ToDecimal(paramMinDiameter.Text);
                    query = query.Where(q => q.DiameterMax >= minDiam);
                }
                if (paramMaxDiametr.TextLength > 0)
                {
                    var maxDiam = Convert.ToDecimal(paramMinDiameter.Text);
                    query = query.Where(q => q.DiameterMax <= maxDiam);
                }
                
                if (paramMinLength.TextLength > 0)
                {
                    var minLength = Convert.ToDecimal(paramMinDiameter.Text);
                    query = query.Where(q => q.LengthMax >= minLength);
                }
                
                if (paramMaxLength.TextLength > 0)
                {
                    var maxLength = Convert.ToDecimal(paramMinDiameter.Text);
                    query = query.Where(q => q.LengthMax <= maxLength);
                }

                ClearMachinesGrid();

                foreach (var mc in query.Include(x => x.Machine).ToList())
                {
                    machinesGrid.Rows.Add(mc.Machine.MachineID, mc.Machine.MachineName, mc.Machine.Model);
                }

                if (machinesGrid.RowCount > 0)
                {
                    machinesGrid.CurrentCell = machinesGrid.Rows[0].Cells[1];
                }
            }
           
        }

        private void ClearMachinesGrid()
        {
            for (int i = 0; i < machinesGrid.Rows.Count; i++)
            {
                machinesGrid.Rows.RemoveAt(i);
            }
        }
        

    }
}
