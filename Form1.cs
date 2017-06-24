using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Opdracht 4: Letterfrequenties
//Maak een programma dat telt hoe vaak bepaalde letters in een document voorkomen.
//Test het uit op teksten in verschillende talen.
//Goed algoritmiseren en bedenken hoe de zaak aangepakt moet worden is hier het belangrijkst.

namespace Letterfrequenties
{
    public partial class Letterfrequentie : Form
    {
        public Letterfrequentie()
        {
            InitializeComponent();
        }

        string letter; // de betreffende letter
        int counter; // teller om de frequentie bij te houden
        string input; // de tekst waarin de letters worden geteld
        int positie; // positie in de tekst om te bepalen of het de betreffende letter is

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "";
            textBoxOutput.Text = "";
            textBoxError.Text = "";
            textBoxLetter.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            textBoxError.Text = "";
            input = textBoxInput.Text;
            letter = textBoxLetter.Text;
            counter = 0;

            try
            {
                if (textBoxLetter.Text == " " || textBoxLetter.Text == "" || textBoxLetter.Text == null)
                {
                    textBoxError.Text = "foutieve invoer: geef een letter, cijfer of ander (lees)teken op waarvan de frequentie kan worden bepaald";
                }
                else if (textBoxInput.Text == " " || textBoxInput.Text == "" || textBoxInput.Text == null)
                {
                    textBoxError.Text = "foutieve invoer: geen tekst gevonden om de frequentie van een bepaald karakter te bepalen";
                }
                else
                {
                    for (positie = 0; positie < input.Length; positie = positie + 1)
                    {
                        var character = input.ElementAt(positie);
                        string betreffendeLetter = character.ToString();
                        if (betreffendeLetter == letter)
                        {
                            counter = counter + 1;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    textBoxOutput.Text = "Het karakter " + letter + " komt " + counter + " keer voor in deze tekst";
                }
            }
            catch
            {
                textBoxError.Text = "Er is iets fout gegaan met het verwerken van de input, probeer opnieuw";
            }
        }        
    }
}