// frmRandomNumberDistribution.cs, RandomNumberGenerator.sln
// CS 1181
// Katherine Wilsdon
// 21 October 2018
// Dr. Cody Permann
/* Description - Create a random number distribution. The user picks a random number generator seed, an array size, and the 
 * maximum value a number in the array can be. The output is a list of the random numbers, the count of the each number
 * between 1 and the provided number by the user, the random distribution statistics. The user can use the trackbar to 
 * look up the value at a certain index in the array.*/
// WOW: Created the random distribution statistics at the user's request
/* Cited:
 * Book, Chapters 5, 6, and 7: Gaddis, T. (2017). Starting out with Visual C# (4th ed.). Boston, PA: Pearson.*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGenerator {    
    public partial class frmRandomNumberDistribution : Form {
        public frmRandomNumberDistribution() {
            InitializeComponent();
        }
        // Declare field variables
        private int seed;        
        private int arraySize;
        private int numbersBetween;
        private int minimum;
        private int maxium;
        private int sum;
        private double mean;

        // Declare random number generator
        Random random;

        // Declare arrays
        int[] randomNumbers;
        int[] countsOfNumbers;
        int[] eachNumber;

        /// <summary>
        /// Initialize the random number generator at the seed provided by the user
        /// </summary>
        private void InitializeRandomNumberGenerator() {
            random = new Random(seed);
        }

        /// <summary>
        /// Initialize the array size of the declared arrays
        /// </summary>
        private void InitializeArraySize() {
            randomNumbers = new int[arraySize];
            countsOfNumbers = new int[numbersBetween];
            eachNumber = new int[numbersBetween];
        }

        /// <summary>
        /// Generates a random number
        /// </summary>
        /// <returns>a random number between 1 and the maximum value provided by the user</returns>
        private int RandomNumberGenerator() {            
            return random.Next(1, numbersBetween + 1);
           
        }
       
        /// <summary>
        /// Create an array containing a random number for each index
        /// </summary>
        private void CreateRandomNumbersArray() {           
            for (int i = 0; i < arraySize; i++) {
                int randomNumber = RandomNumberGenerator();
                randomNumbers[i] = randomNumber;
                // Displays array values in a listbox
                lbArray.Items.Add(randomNumbers[i]);
            }           
        }

        /// <summary>
        /// Create a count array 
        /// </summary>
        private void CreateCountArray() {
            for (int i = 0; i < numbersBetween; i++) {
                // Creates an array of each number between 1 and the provided number by the user
                eachNumber[i] = i + 1;
                int count = 0;
                for (int j = 0; j < arraySize; j++) {
                    // If the randomNumbers array value equals the eachNumber array value, add 1 to the count
                    if (randomNumbers[j] == eachNumber[i]) {
                        count += 1;
                    }
                }
                // Creates an array of the count of the each number between 1 and the provided number by the user
                countsOfNumbers[i] = count;
                // Resets count
                count = 0;
            }
        }

        /// <summary>
        /// Displays the count of the each number between 1 and the provided number by the user
        /// </summary>
        private void CreateListbox() { 
            for (int i = 0; i < numbersBetween; i++) {
                // When the count of a number equals 1, the expression is singular, else the expression is plural
                if (countsOfNumbers[i] == 1) {
                    string oneNumber = "There is " + countsOfNumbers[i] +" " + eachNumber[i];
                    lbHowManyNumbers.Items.Add(oneNumber);
                } else {
                    string notOneNumber = "There are " + countsOfNumbers[i] + " " + eachNumber[i] + "'s";
                    lbHowManyNumbers.Items.Add(notOneNumber);
                }
            }
        }
        /// <summary>
        /// Displays the statistics of the random number distribution on the GUI
        /// </summary>
        private void Statistics() {
            // Assigns the mimimum, maximum, sum, and mean variables
            minimum = randomNumbers.Min();
            maxium = randomNumbers.Max();
            sum = randomNumbers.Sum();
            mean = (double) sum / arraySize;            
        }

        /// <summary>
        /// Shows the statistics for the marked checkbox
        /// </summary>
        private void OutputRequestedStatistics() {
            // Displays the mimimum on the GUI when the checkbox is marked
            if (chkMinimum.Checked) {
                lblMinimum.Visible = true;
                lblOutputMinimum.Visible = true;
                lblOutputMinimum.Text = minimum.ToString("n0");
            }
            // Displays the maximum on the GUI when the checkbox is marked
            if (chkMaximum.Checked) {
                lblMaximum.Visible = true;
                lblOutputMaximum.Visible = true;
                lblOutputMaximum.Text = maxium.ToString("n0");
            }

            // Displays the range on the GUI when the checkbox is marked
            if (chkRange.Checked) {
                lblRange.Visible = true;
                lblOutputRange.Visible = true;
                lblOutputRange.Text = minimum.ToString("n0") + "-" + maxium.ToString("n0");
            }

            // Displays the sum on the GUI when the checkbox is marked
            if (chkSum.Checked) {
                lblSum.Visible = true;
                lblOutputSum.Visible = true;
                lblOutputSum.Text = sum.ToString("n0");
            }

            // Displays the mean on the GUI when the checkbox is marked
            if (chkMean.Checked) {
                lblMean.Visible = true;
                lblOutputMean.Visible = true;
                lblOutputMean.Text = mean.ToString("n1");
            }            
        }

        /// <summary>
        /// Sets the statistic labels to invisible
        /// </summary>
        private void StatisticsInvisible() {
            lblMinimum.Visible = false;
            lblOutputMinimum.Visible = false;
            lblMaximum.Visible = false;
            lblOutputMaximum.Visible = false;
            lblRange.Visible = false;
            lblOutputRange.Visible = false;
            lblSum.Visible = false;
            lblOutputSum.Visible = false;
            lblMean.Visible = false;
            lblOutputMean.Visible = false;
        }

        /// <summary>
        /// Sets the trackbar and related labels to visible
        /// </summary>
        private void TrackbarVisible () {
            trValueAtIndex.Visible = true;
            lblOutputValue.Visible = true;
            lblValueAtIndex.Visible = true;            
        }

        /// <summary>
        /// Sets the trackbar and related labels to invisible
        /// </summary>
        private void TrackbarInvisible() {
            trValueAtIndex.Visible = false;
            lblOutputValue.Visible = false;
            lblValueAtIndex.Visible = false;
        }
        /// <summary>
        /// Clear the trackbar and the related labels
        /// </summary>
        private void ClearTrackbar() {
            lblOutputValue.Text = "";
            lblValueAtIndex.Text = "Value at Index 0:";
            trValueAtIndex.Value = trValueAtIndex.Minimum;
        }
        /// <summary>
        /// Clears the contents in the listboxes
        /// </summary>
        private void ClearListBoxes() {
            lbArray.Items.Clear();
            lbHowManyNumbers.Items.Clear();
        }

        /// <summary>
        /// Clears the contents in the textboxes
        /// </summary>
        private void ClearTextboxes() {
            txtSeed.Text = "";
            txtArraySize.Text = "";
            txtGenerateNumbersBetween.Text = "";
        }
        
        /// <summary>
        /// Unchecks the checkboxes
        /// </summary>
        private void ClearCheckboxes() {
            chkMinimum.Checked = false;
            chkMaximum.Checked = false;
            chkRange.Checked = false;
            chkSum.Checked = false;
            chkMean.Checked = false;
        }

        /// <summary>
        /// Generates the random number distribution when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e) {
            ClearListBoxes();
            StatisticsInvisible();
            InitializeArraySize();
            InitializeRandomNumberGenerator();
            CreateRandomNumbersArray();
            CreateCountArray();
            CreateListbox();
            Statistics();
            OutputRequestedStatistics();
            TrackbarVisible();
            // Outputs the value for index 0 in the array
            lblOutputValue.Text = randomNumbers[0].ToString();
        }

        /// <summary>
        /// Clears the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e) {
            ClearListBoxes();
            ClearTextboxes();
            TrackbarInvisible();
            ClearTrackbar();
            StatisticsInvisible();
            ClearCheckboxes();
        }

        /// <summary>
        /// Close the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }       

        /// <summary>
        /// Assigns the array size provided by the user to the arraySize variable 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtArraySize_TextChanged(object sender, EventArgs e) {            
            int.TryParse(txtArraySize.Text, out arraySize);
            //Sets the minimum and maximum of the trackbar
            trValueAtIndex.Minimum = 0;
            trValueAtIndex.Maximum = arraySize - 1;
        }

        /// <summary>
        /// Assigns the value from the GenerateNumberBetween textbox to the numberBetween variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGenerateNumbersBetween_TextChanged(object sender, EventArgs e) {
            int.TryParse(txtGenerateNumbersBetween.Text, out numbersBetween);
        }

        /// <summary>
        /// Assigns the value from the Seed textbox to the seed variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSeed_TextChanged(object sender, EventArgs e) {
            int.TryParse(txtSeed.Text, out seed);
        }

        /// <summary>
        /// Updates the labels depending on the value of the trackbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trValueAtIndex_Scroll(object sender, EventArgs e) {
            int trackbar = trValueAtIndex.Value;
            lblValueAtIndex.Text = "Value at Index " + trackbar + ":";
            lblOutputValue.Text = randomNumbers[trackbar].ToString();
        }
    }
}
