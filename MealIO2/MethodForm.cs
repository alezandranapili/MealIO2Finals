using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealIO2
{
    public partial class MethodForm : Form
    {
        public MethodForm()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            MainDishForm mainDishForm = new MainDishForm();
            mainDishForm.Show();
            this.Hide();
        }
        public void forms(object sender, EventArgs e)
        {
            BudgetForm budgetForm = new BudgetForm();
            AppetiteLevelForm appetiteLevelForm = new AppetiteLevelForm();
            MainDishForm mainDishForm2 = new MainDishForm();
        }

//method
        private void steamed_Click(object sender, EventArgs e)
        {
    //low budget
            if (BudgetForm.lowbudgetClicked)
            {
        //low appetite
                if (AppetiteLevelForm.lowappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal1Form meal1Form = new Meal1Form();
                        meal1Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal4Form meal4Form = new Meal4Form();
                        meal4Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        ErrorBudgetForm errorBudgetForm = new ErrorBudgetForm();
                        errorBudgetForm.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal7Form meal7Form = new Meal7Form();
                        meal7Form.Show();
                        this.Hide();
                    }
                    else if(MainDishForm.porkClicked)
                    {
                        ErrorMethodForm errorMethodForm = new ErrorMethodForm();
                        errorMethodForm.Show();
                        this.Hide();
                    }
                }
        //mid appetite
                else if (AppetiteLevelForm.midappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal12Form meal12Form = new Meal12Form();
                        meal12Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal15Form meal15Form = new Meal15Form();
                        meal15Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        ErrorBudgetForm errorForm = new ErrorBudgetForm();
                        errorForm.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal18Form meal18Form = new Meal18Form();
                        meal18Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        ErrorMethodForm errorMethodForm = new ErrorMethodForm();
                        errorMethodForm.Show();
                        this.Hide();
                    }
                }
            //high appetite
                else if(AppetiteLevelForm.highappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal23Form meal23Form = new Meal23Form();
                        meal23Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal26Form meal26Form = new Meal26Form();
                        meal26Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        ErrorBudgetForm errorForm = new ErrorBudgetForm();
                        errorForm.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal29Form meal29Form = new Meal29Form();
                        meal29Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        ErrorMethodForm errorMethodForm = new ErrorMethodForm();
                        errorMethodForm.Show();
                        this.Hide();
                    }
                }
            }
    //mid budget
            else if (BudgetForm.midbudgetClicked)
            {
        //low appetite
                if (AppetiteLevelForm.lowappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal34Form meal34Form = new Meal34Form();
                        meal34Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal37Form meal37Form = new Meal37Form();
                        meal37Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        ErrorBudgetForm errorForm = new ErrorBudgetForm();
                        errorForm.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal40Form meal40Form = new Meal40Form();
                        meal40Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        ErrorMethodForm errorMethodForm = new ErrorMethodForm();
                        errorMethodForm.Show();
                        this.Hide();
                    }
                }
        //mid appetite
                else if (AppetiteLevelForm.midappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal45Form meal45Form = new Meal45Form();
                        meal45Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal48Form meal48Form = new Meal48Form();
                        meal48Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        ErrorBudgetForm errorForm = new ErrorBudgetForm();
                        errorForm.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal51Form meal51Form = new Meal51Form();
                        meal51Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        ErrorMethodForm errorMethodForm = new ErrorMethodForm();
                        errorMethodForm.Show();
                        this.Hide();
                    }
                }
        //high appetite
                else if(AppetiteLevelForm.highappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal56Form meal56Form = new Meal56Form();
                        meal56Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal59Form meal59Form = new Meal59Form();
                        meal59Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        ErrorBudgetForm errorForm = new ErrorBudgetForm();
                        errorForm.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal62Form meal62Form = new Meal62Form();
                        meal62Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        ErrorMethodForm errorMethodForm = new ErrorMethodForm();
                        errorMethodForm.Show();
                        this.Hide();
                    }
                }
            }
    //high budget
            else if (BudgetForm.highbudgetClicked)
            {
        //low appetite
                if (AppetiteLevelForm.lowappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal67Form meal67Form = new Meal67Form();
                        meal67Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal70Form meal70Form = new Meal70Form();
                        meal70Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        Meal73Form meal73Form = new Meal73Form();
                        meal73Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal76Form meal76Form = new Meal76Form();
                        meal76Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        ErrorMethodForm errorMethodForm = new ErrorMethodForm();
                        errorMethodForm.Show();
                        this.Hide();
                    }
                }
        //mid appetite
                else if (AppetiteLevelForm.midappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal81Form meal81Form = new Meal81Form();
                        meal81Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal84Form meal84Form = new Meal84Form();
                        meal84Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                         Meal87Form meal87Form   = new Meal87Form();
                        meal87Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal90Form meal90Form = new Meal90Form();
                        meal90Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        ErrorMethodForm errorMethodForm = new ErrorMethodForm();
                        errorMethodForm.Show();
                        this.Hide();
                    }
                }
        //high appetite
                else if (AppetiteLevelForm.highappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal95Form meal95Form = new Meal95Form();
                        meal95Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal98Form meal98Form = new Meal98Form();
                        meal98Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        Meal101Form meal101Form = new Meal101Form();
                        meal101Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal104Form meal104Form = new Meal104Form();
                        meal104Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        ErrorMethodForm errorMethodForm = new ErrorMethodForm();
                        errorMethodForm.Show();
                        this.Hide();
                    }
                }
            }
        }
//method
        private void fried_Click(object sender, EventArgs e)
        {
    //low budget
            if(BudgetForm.lowbudgetClicked)
            {
        //low appetite
                if(AppetiteLevelForm.lowappetiteClicked)
                {
            //main dish
                    if(MainDishForm.chickenClicked)
                    {
                        this.Hide();
                        Meal2Form meal2Form = new Meal2Form();
                        meal2Form.Show();
                        
                    }
                    else if(MainDishForm.fishClicked)
                    {
                        this.Hide();
                        Meal5Form meal5Form = new Meal5Form();
                        meal5Form.Show();
                        
;                    }
                    else if(MainDishForm.beefClicked)
                    {
                        this.Hide();
                        ErrorBudgetForm errorForm = new ErrorBudgetForm();
                        errorForm.Show();
                       
                    }
                    else if(MainDishForm.vegetablesClicked)
                    {
                        this.Hide();
                        Meal8Form meal8Form = new Meal8Form();
                        meal8Form.Show();
                        
                    }
                    else if(MainDishForm.porkClicked)
                    {

                        this.Hide();
                        Meal10Form meal10Form = new Meal10Form();
                        meal10Form.Show();
                   
                    }
                }
        //mid appetite
                else if(AppetiteLevelForm.midappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal13Form meal13Form = new Meal13Form();
                        meal13Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal16Form meal16Form = new Meal16Form();
                        meal16Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        ErrorBudgetForm errorForm = new ErrorBudgetForm();
                        errorForm.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal19Form meal19Form = new Meal19Form();
                        meal19Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        Meal21Form meal21Form = new Meal21Form();
                        meal21Form.Show();
                        this.Hide();
                    }
                }
        //high appetite
                else if (AppetiteLevelForm.highappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal24Form meal24Form = new Meal24Form();
                        meal24Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal27Form meal27Form = new Meal27Form();
                        meal27Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        ErrorBudgetForm errorForm = new ErrorBudgetForm();
                        errorForm.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal30Form meal30Form = new Meal30Form();
                        meal30Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        Meal32Form meal32Form = new Meal32Form();
                        meal32Form.Show();
                        this.Hide();
                    }
                }
            }
    //mid budget
            else if(BudgetForm.midbudgetClicked)
            {
        //low appetite
                if (AppetiteLevelForm.lowappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal35Form meal35Form = new Meal35Form();
                        meal35Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal38Form meal38Form = new Meal38Form();
                        meal38Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        ErrorBudgetForm errorForm = new ErrorBudgetForm();
                        errorForm.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal41Form meal41Form = new Meal41Form();
                        meal41Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        Meal43Form meal43Form = new Meal43Form();
                        meal43Form.Show();
                        this.Hide();
                    }
                }
        //mid appetite
                else if (AppetiteLevelForm.midappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal46Form meal46Form = new Meal46Form();
                        meal46Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal49Form meal49Form = new Meal49Form();
                        meal49Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        ErrorBudgetForm errorForm = new ErrorBudgetForm();
                        errorForm.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal52Form meal52Form = new Meal52Form();
                        meal52Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        Meal54Form meal54Form = new Meal54Form();
                        meal54Form.Show();
                        this.Hide();
                    }
                }
        //high appetite
                else if (AppetiteLevelForm.highappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                       Meal57Form meal57Form = new Meal57Form();
                       meal57Form.Show();
                       this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal60Form meal60Form = new Meal60Form();
                        meal60Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        ErrorBudgetForm errorForm = new ErrorBudgetForm();
                        errorForm.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal63Form meal63Form = new Meal63Form();
                        meal63Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        Meal65Form meal65Form = new Meal65Form();
                        meal65Form.Show();
                        this.Hide();
                    }
                }
            }
    //high budget
            else if (BudgetForm.highbudgetClicked)
            {
        //low appetite
                if (AppetiteLevelForm.lowappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal68Form meal68Form = new Meal68Form();
                        meal68Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal71Form meal71Form = new Meal71Form();
                            meal71Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        Meal74Form meal74Form = new Meal74Form();
                        meal74Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal77Form meal77Form = new Meal77Form();
                        meal77Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        Meal79Form meal79Form = new Meal79Form();
                        meal79Form.Show();
                        this.Hide();
                    }
                }
        //mid appetite
                else if (AppetiteLevelForm.midappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                     Meal82Form meal82Form = new Meal82Form();
                            meal82Form.Show();
                            this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal85Form meal85Form = new Meal85Form();
                        meal85Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        Meal88Form meal88Form = new Meal88Form();
                        meal88Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal91Form meal91Form = new Meal91Form();
                        meal91Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        Meal93Form meal93Form = new Meal93Form();
                        meal93Form.Show();
                        this.Hide();
                    }
                }
        //high appetite
                else if (AppetiteLevelForm.highappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                       Meal96Form meal96Form = new Meal96Form();
                        meal96Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal99Form meal99Form = new Meal99Form();
                        meal99Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        Meal102Form meal102Form = new Meal102Form();
                        meal102Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal105Form meal105Form = new Meal105Form();
                        meal105Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        Meal107Form meal107Form = new Meal107Form();
                        meal107Form.Show();
                        this.Hide();
                    }
                }
            }
        }

//method
        private void soup_Click(object sender, EventArgs e)
        {
    //low budget
            if (BudgetForm.lowbudgetClicked)
            {
        //low appetite
                if (AppetiteLevelForm.lowappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal3Form meal3Form = new Meal3Form();
                        meal3Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal6Form meal6Form = new Meal6Form();
                        meal6Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        ErrorBudgetForm errorForm = new ErrorBudgetForm();
                        errorForm.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal9Form meal9Form = new Meal9Form();
                        meal9Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        Meal11Form meal11Form = new Meal11Form();   
                        meal11Form.Show();
                        this.Hide();
;                    }
                }
        //mid appetite
                else if (AppetiteLevelForm.midappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal14Form meal14Form = new Meal14Form();
                        meal14Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal17Form meal17Form = new Meal17Form();
                        meal17Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        ErrorBudgetForm errorForm = new ErrorBudgetForm();
                        errorForm.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal20Form meal20Form = new Meal20Form();
                        meal20Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        Meal22Form meal22Form = new Meal22Form();
                        meal22Form.Show();
                        this.Hide();
                    }
                }
        //high appetite
                else if (AppetiteLevelForm.highappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal25Form meal25Form = new Meal25Form();
                        meal25Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal28Form meal28Form = new Meal28Form();
                        meal28Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        ErrorBudgetForm errorForm = new ErrorBudgetForm();
                        errorForm.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal31Form meal31Form = new Meal31Form();
                        meal31Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        Meal33Form meal33Form = new Meal33Form();
                        meal33Form.Show();
                        this.Hide();
                    }
                }
            }
    //mid budget
            else if (BudgetForm.midbudgetClicked)
            {
        //low appetite
                if (AppetiteLevelForm.lowappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal36Form meal36Form = new Meal36Form();
                        meal36Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal39Form meal39Form = new Meal39Form();
                        meal39Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        ErrorBudgetForm errorForm = new ErrorBudgetForm();
                        errorForm.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal42Form meal42Form = new Meal42Form();
                        meal42Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        Meal44Form meal44Form = new Meal44Form();
                        meal44Form.Show();
                        this.Hide();
                    }
                }
        //mid appetite
                else if (AppetiteLevelForm.midappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal47Form meal47Form = new Meal47Form();
                        meal47Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal50Form meal50Form = new Meal50Form();
                        meal50Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        ErrorBudgetForm errorForm = new ErrorBudgetForm();
                        errorForm.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal53Form meal53Form = new Meal53Form();
                        meal53Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        Meal55Form meal55Form = new Meal55Form();
                        meal55Form.Show();
                        this.Hide();
                    }
                }
        //high appetite
                else if (AppetiteLevelForm.highappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal58Form meal58Form = new Meal58Form();
                        meal58Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal61Form meal61Form = new Meal61Form();
                        meal61Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        ErrorBudgetForm errorForm = new ErrorBudgetForm();
                        errorForm.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal64Form meal64Form = new Meal64Form();
                        meal64Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        Meal66Form meal66Form = new Meal66Form();
                        meal66Form.Show();
                        this.Hide();
                    }
                }
            }
    //high budget
            else if (BudgetForm.highbudgetClicked)
            {
        //low appetite
                if (AppetiteLevelForm.lowappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal69Form meal69Form = new Meal69Form();
                        meal69Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal72Form meal72Form = new Meal72Form();
                        meal72Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        Meal75Form meal75Form = new Meal75Form();
                        meal75Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal78Form meal78Form = new Meal78Form();
                        meal78Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        Meal80Form meal80Form = new Meal80Form();
                        meal80Form.Show();
                        this.Hide();
                    }
                }
        //mid appetite
                else if (AppetiteLevelForm.midappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal83Form meal83Form = new Meal83Form();
                        meal83Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal86Form meal86Form = new Meal86Form(); 
                            meal86Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        Meal89Form meal89Form = new Meal89Form();
                        meal89Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal92Form meal92Form = new Meal92Form();
                        meal92Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        Meal94Form meal94Form = new Meal94Form();
                        meal94Form.Show();
                        this.Hide();
                    }
                }
        //high appetite
                else if (AppetiteLevelForm.highappetiteClicked)
                {
            //main dish
                    if (MainDishForm.chickenClicked)
                    {
                        Meal97Form meal97Form = new Meal97Form();
                        meal97Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.fishClicked)
                    {
                        Meal100Form meal100Form = new Meal100Form();
                        meal100Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.beefClicked)
                    {
                        Meal103Form meal103Form = new Meal103Form();
                        meal103Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.vegetablesClicked)
                    {
                        Meal106Form meal106Form = new Meal106Form();
                        meal106Form.Show();
                        this.Hide();
                    }
                    else if (MainDishForm.porkClicked)
                    {
                        Meal108Form meal108Form = new Meal108Form();
                        meal108Form.Show();
                        this.Hide();
                    }
                }
            }
        }
    

       
    
    }
}
