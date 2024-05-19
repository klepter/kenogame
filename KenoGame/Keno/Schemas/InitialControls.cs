using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KenoGame.Keno.Schemas
{
    public class InitialControls
    {
        public Label PlayerBankLabel { get; private set; }
        public NumericUpDown BetNumeric { get; private set; }
        public NumericUpDown AttemptNumeric { get; private set; }

        public InitialControls(Label playerBankLabel, NumericUpDown betNumeric, NumericUpDown attemptNumeric)
        {
            PlayerBankLabel = playerBankLabel;
            BetNumeric = betNumeric;
            AttemptNumeric = attemptNumeric;
        }
    }
}
