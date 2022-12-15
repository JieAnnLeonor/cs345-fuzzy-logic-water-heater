using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DotFuzzy;
using System.Windows.Forms;

namespace FuzzyLogic
{
    public partial class Form1 : Form
    {
        FuzzyEngine fe;
        MembershipFunctionCollection levelsense, tempsense, heatknob;
        LinguisticVariable _levelsense, _tempsense, _heatknob;
        FuzzyRuleCollection myrules;

        public Form1()
        {
            InitializeComponent();
        }

        public void setMembers()
        {
            levelsense = new MembershipFunctionCollection();
            levelsense.Add(new MembershipFunction("LOW", 0.0, 0.0, 50.0, 55.0));
            levelsense.Add(new MembershipFunction("OK", 50.0, 55.0, 55.0, 60.0));
            levelsense.Add(new MembershipFunction("HIGH", 60.0, 75.0, 100.0, 100.0));
            _levelsense = new LinguisticVariable("LEVEL", levelsense);

            tempsense = new MembershipFunctionCollection();
            tempsense.Add(new MembershipFunction("SMALL", -10.0, -10.0, -5.0, 0.0));
            tempsense.Add(new MembershipFunction("MEDIUM", -5.0, 1.0, 1.0, 5.0));
            tempsense.Add(new MembershipFunction("LARGE", 0.0, 5.0, 10.0, 10.0));
            _tempsense = new LinguisticVariable("TEMP", tempsense);

            heatknob = new MembershipFunctionCollection();
            heatknob.Add(new MembershipFunction("AVERYLITTLE", 0.0, 2.0, 4.0, 6.0));
            heatknob.Add(new MembershipFunction("ALITTLE", 4.0, 6.0, 6.0, 8.0));
            heatknob.Add(new MembershipFunction("AGOODAMOUNT", 6.0, 8.0, 8.0, 10.0));
            heatknob.Add(new MembershipFunction("ALOT", 8.0, 10.0, 10.0, 10.0));
            _heatknob = new LinguisticVariable("HEATKNOB", heatknob);
        }

        public void setRules()
        {
            myrules = new FuzzyRuleCollection();
            myrules.Add(new FuzzyRule("IF (LEVEL IS LOW) AND (TEMP IS SMALL) THEN HEATKNOB IS AVERYLITTLE"));
            myrules.Add(new FuzzyRule("IF (LEVEL IS LOW) AND (TEMP IS MEDIUM) THEN HEATKNOB IS ALITTLE"));
            myrules.Add(new FuzzyRule("IF (LEVEL IS LOW) AND (TEMP IS LARGE) THEN HEATKNOB IS ALITTLE"));
            myrules.Add(new FuzzyRule("IF (LEVEL IS OK) AND (TEMP IS SMALL) THEN HEATKNOB IS AVERYLITTLE"));
            myrules.Add(new FuzzyRule("IF (LEVEL IS OK) AND (TEMP IS MEDIUM) THEN HEATKNOB IS ALITTLE"));
            myrules.Add(new FuzzyRule("IF (LEVEL IS OK) AND (TEMP IS LARGE) THEN HEATKNOB IS AGOODAMOUNT"));
            myrules.Add(new FuzzyRule("IF (LEVEL IS HIGH) AND (TEMP IS SMALL) THEN HEATKNOB IS AGOODAMOUNT"));
            myrules.Add(new FuzzyRule("IF (LEVEL IS HIGH) AND (TEMP IS MEDIUM) THEN HEATKNOB IS AGOODAMOUNT"));
            myrules.Add(new FuzzyRule("IF (LEVEL IS HIGH) AND (TEMP IS LARGE) THEN HEATKNOB IS ALOT"));
        }    

        public void setFuzzyEngine()
        {
            fe = new FuzzyEngine();
            fe.LinguisticVariableCollection.Add(_levelsense);
            fe.LinguisticVariableCollection.Add(_tempsense);
            fe.LinguisticVariableCollection.Add(_heatknob);
            fe.FuzzyRuleCollection = myrules;
        }

        public void fuziffyvalues()
        {
            _levelsense.InputValue = (Convert.ToDouble(textBox1.Text));
            _levelsense.Fuzzify("LOW");
            _tempsense.InputValue = (Convert.ToDouble(textBox2.Text));
            _tempsense.Fuzzify("SMALL");

        }
        public void defuzzy()
        {
            setFuzzyEngine();
            fe.Consequent = "HEATKNOB";
            textBox3.Text = "" + fe.Defuzzify();
        }

        public void computenewlevel()
        {

            double oldlevel = Convert.ToDouble(textBox1.Text);
            double oldheatknob = Convert.ToDouble(textBox3.Text);
            double oldtemp = Convert.ToDouble(textBox2.Text);
            double newlevel = ((1 - 0.1) * (oldlevel)) + (oldheatknob - (0.1 * oldtemp));
            textBox1.Text = "" + newlevel;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }      

        private void defuziffyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }       

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setMembers();
            setRules();
            //setFuzzyEngine();
        }       

        private void LevelBTN_Click(object sender, EventArgs e)
        {
            _levelsense.InputValue = (Convert.ToDouble(textBox1.Text));
            _levelsense.Fuzzify("OK");
        }       

        private void TempBTN_Click(object sender, EventArgs e)
        {
            _tempsense.InputValue = (Convert.ToDouble(textBox2.Text));
            _tempsense.Fuzzify("MEDIUM");
        }

        private void DefuzzifyBTN_Click(object sender, EventArgs e)
        {
            setFuzzyEngine();
            fe.Consequent = "HEATKNOB";
            textBox3.Text = "" + fe.Defuzzify();
        }

        private void NewLevelBTN_Click(object sender, EventArgs e)
        {
            computenewlevel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setMembers();
            setRules();
        }

        private void CBTN_Click(object sender, EventArgs e)
        {
            fuziffyvalues();
            defuzzy();
            computenewlevel();
        }
    }
}
