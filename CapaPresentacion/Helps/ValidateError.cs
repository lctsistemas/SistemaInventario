﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CapaPresentacion.Helps
{
    public class ValidateError
    {
        public static ErrorProvider validate = new ErrorProvider();

        public static void Validate_text(Guna.UI2.WinForms.Guna2TextBox txt, string m)
        {

            //validate.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            // validate.BlinkRate = 250 velocidad en milesegundos en que parpadea
            if (String.IsNullOrWhiteSpace(txt.Text))
                validate.SetError(txt, m);
            else
                validate.SetError(txt, null);
        }

        public static void Validate_combo(ComboBox cbo, string m)
        {
            if (String.IsNullOrWhiteSpace(cbo.Text))
            {
                validate.SetError(cbo, m);
            }
            else
            {
                validate.SetError(cbo, null);
            }
        }


        #region VALIDACION CON CANCELACION 
        //VALIDAR COMBO

        public static void Validate_combo(CancelEventArgs e, ComboBox cbo, string m)
        {
            if (String.IsNullOrWhiteSpace(cbo.Text))
            {
                e.Cancel = true;
                cbo.Focus();
                validate.SetError(cbo, m);
            }
            else
            {
                validate.SetError(cbo, null);
            }
        }

        public static void Validate_text(CancelEventArgs e, TextBox txt, string m)
        {

            if (String.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = true;
                txt.Focus();
                validate.SetError(txt, m);
            }
            else
            {
                e.Cancel = false;
                validate.SetError(txt, null);
            }

        }
        #endregion
    }
}
