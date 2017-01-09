<H1>Short review of Password Generator</H1>
To use class library you need at first do <b>"using RandomPassGenerator"</b> to your project, create object of <b>RandomPasswordGenerator</b> class and call <b>GeneratePasswordRnd</b> function.
By default all parameters but AllCheckBox are false, which allows to generate random password with lowercase/highercase alphabet, symbols and numbers.

Code snipet for WPF project is below:

            RandomPasswordGenerator gen = new RandomPasswordGenerator();

            //Can be passed 0 argument, all except "AllCheckBox" are false by default
            pswdTextBoxHEX.Text = gen.GeneratePasswordRnd(LowCheckBox.IsChecked, HighCheckBox.IsChecked,
                                                        SymbolsCheckBox.IsChecked, NumbersCheckBox.IsChecked
                                                        ,AllCheckBox.IsChecked);
