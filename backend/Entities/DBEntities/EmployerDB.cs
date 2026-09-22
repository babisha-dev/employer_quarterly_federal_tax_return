public class  EmployerDB
{
    public Guid id{get;set;}
    public String  Ein{get;set;}
    public string Name{get;set;}
    public string TradeName{get;set;}
    public string Street{get;set;}
    public string RoomSuite{get;set;}
    public string City{get;set;}
    public string State{get;set;}
    public string ZipCode{get;set;}
    public string ForeignCountry{get;set;}
    public string ForeignProvinceCountry{get;set;}
    public string ForeignPostalCode{get;set;}
    public DateTime CreatedAt{get;set;}
    public DateTime UpdatedAt{get;set;}
    public bool isDeleted{get;set;}

}