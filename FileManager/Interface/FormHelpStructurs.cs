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

        /// <summary>
        /// Заполнение полей, связанных с допустимым размером файла
        /// </summary>
        /// <param name="filter"></param>
        private void FillSize(Filter filter)
        {
            if (filter.HasSizeBitsInterval)
            {
                checkbSize.Checked = false;
                numSize1.Enabled = true;
                numSize2.Enabled = true;

                numSize1.Value = filter.SizeBitesInterval.Start;
                numSize2.Value = filter.SizeBitesInterval.End;
            }
            else
            {
                checkbSize.Checked = true;
                numSize1.Enabled = false;
                numSize2.Enabled = false;
            }
        }

        private void FillDateCreate(Filter filter)
        {
            if (filter.HasDateTimeIntervalCreate)
            {
                checkbDateCreate.Checked = false;
                datetCreate1.Enabled = true;
                datetCreate2.Enabled = true;

                datetCreate1.Value = filter.DateTimeIntervalChange.Start;
                datetCreate2.Value = filter.DateTimeIntervalChange.End;
            }
            else
            {
                checkbDateCreate.Checked = true;
                datetCreate1.Enabled = false;
                datetCreate2.Enabled = false;
            }
        }

        private void FillDateChange(Filter filter)
        {
            if (filter.HasDateTimeIntervalChange)
            {
                checkbDateChange.Checked = false;
                datetChange1.Enabled = true;
                datetChange2.Enabled = true;

                datetChange1.Value = filter.DateTimeIntervalChange.Start;
                datetChange2.Value = filter.DateTimeIntervalChange.End;
            }
            else
            {
                checkbDateChange.Checked = true;
                datetChange1.Enabled = false;
                datetChange2.Enabled = false;
            }
        }
    }
}
