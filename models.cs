public class StatementMonth
    {
        public string MonthName { get; set; }

    }

    public class MonthCollectionModel
    {
        public List<StatementMonth> AvailableMonths { get; set; }
        public List<StatementMonth> SelectedMonths { get; set; }

    }
