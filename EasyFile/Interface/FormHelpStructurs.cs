using Core;

namespace Interface
{
    public partial class Form1
    {
        private void SetMaxMinValues()
        {
            numSize1.Minimum = 0;
            numSize1.Maximum = long.MaxValue;
            numSize2.Minimum = 0;
            numSize2.Maximum = long.MaxValue;

            datetChange1.MinDate = DateTime.MinValue;
            datetChange1.MaxDate = DateTime.MaxValue;
            datetChange2.MinDate = DateTime.MinValue;
            datetChange2.MaxDate = DateTime.MaxValue;
            datetCreate1.MinDate = DateTime.MinValue;
            datetCreate1.MaxDate = DateTime.MaxValue;
            datetCreate2.MinDate = DateTime.MinValue;
            datetCreate2.MaxDate = DateTime.MaxValue;
        }

        private TypeSize GetTypeSize(string name)
        {
            switch (name)
            {
                case "Байт":
                    return TypeSize.b;
                case "Кб":
                    return TypeSize.Kb;
                case "Мб":
                    return TypeSize.Mb;
                case "Гб":
                    return TypeSize.Gb;
                default:
                    return new TypeSize();
            }
        }

        #region Заполнение
        /// <summary>
        /// Заполнение полей, связанных с допустимым размером файла
        /// </summary>
        /// <param name="filter"></param>
        private void FillSize(Filter filter)
        {
            if (filter.HasSizeBitsInterval)
            {
                checkbSize.Checked = false;
                EnableSize();

                numSize1.Value = filter.SizeBitesInterval.Start;
                numSize2.Value = filter.SizeBitesInterval.End;
                comboSize.SelectedIndex = (int)filter.SizeBitesInterval.TypeSize;
            }
            else
            {
                checkbSize.Checked = true;
                DisableSize();
            }
        }

        private void FillDateCreate(Filter filter)
        {
            if (filter.HasDateTimeIntervalCreate)
            {
                checkbDateCreate.Checked = false;
                EnableDateCreate();

                datetCreate1.Value = filter.DateTimeIntervalCreate.Start;
                datetCreate2.Value = filter.DateTimeIntervalCreate.End;
            }
            else
            {
                checkbDateCreate.Checked = true;
                DisableDateCreate();
            }
        }

        private void FillDateChange(Filter filter)
        {
            if (filter.HasDateTimeIntervalChange)
            {
                checkbDateChange.Checked = false;
                EnableDateChange();

                datetChange1.Value = filter.DateTimeIntervalChange.Start;
                datetChange2.Value = filter.DateTimeIntervalChange.End;
            }
            else
            {
                checkbDateChange.Checked = true;
                DisableDateChange();
            }
        }
        #endregion

        #region Блокировка/разблокировка
        private void EnableSize()
        {
            numSize1.Enabled = true;
            numSize2.Enabled = true;
            comboSize.Enabled = true;
            comboSize.SelectedIndex = 1;
        }
        private void DisableSize()
        {
            numSize1.Enabled = false;
            numSize2.Enabled = false;
            comboSize.Enabled = false;

            numSize1.Value = 0;
            numSize2.Value = 0;
            comboSize.SelectedIndex = -1;
        }

        private void EnableDateCreate()
        {
            datetCreate1.Enabled = true;
            datetCreate2.Enabled = true;
        }
        private void DisableDateCreate()
        {
            datetCreate1.Enabled = false;
            datetCreate2.Enabled = false;

            datetCreate1.Value = DateTime.Now;
            datetCreate2.Value = DateTime.Now;
        }

        private void EnableDateChange()
        {
            datetChange1.Enabled = true;
            datetChange2.Enabled = true;
        }
        private void DisableDateChange()
        {
            datetChange1.Enabled = false;
            datetChange2.Enabled = false;

            datetChange1.Value = DateTime.Now;
            datetChange2.Value = DateTime.Now;
        }
        #endregion
    }
}
