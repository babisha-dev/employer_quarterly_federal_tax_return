public class  EmployerDB
{
    public Guid id{get;set;}
    public string  ein{get;set;}
    public string name{get;set;}
    public string trade_name{get;set;}
    public string street{get;set;}
    public string room_suite{get;set;}
    public string city{get;set;}
    public string state{get;set;}
    public string zip_code{get;set;}
    public string foreign_country{get;set;}
    public string foreign_province_country{get;set;}
    public string foreign_postal_code{get;set;}
    public DateTime created_at{get;set;}
    public DateTime updated_at{get;set;}
    public bool is_deleted{get;set;}

}