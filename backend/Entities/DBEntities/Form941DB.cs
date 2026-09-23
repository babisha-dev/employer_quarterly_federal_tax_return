public class Form941DB
{
    public Guid id{get;set;}
    public Guid employer_id{get;set;}
    public int year{get;set;}
    public int quarter{get;set;}
    public DateTime created_at{get;set;}
    public DateTime updated_at{get;set;}
    public bool is_deleted{get;set;}

    //part1

    public int number_of_employees{get;set;}
    public decimal wages_tips_other_compensation{get;set;}
    public decimal federal_income_tax_withheld{get;set;}
    public bool no_social_security_medicare_wages{get;set;}

    public decimal taxable_social_security_wages{get;set;}
    public decimal social_security_tax{get;set;}// after calc

    public decimal taxable_social_security_tips{get;set;}
    public decimal social_security_tips_tax{get;set;}//after calc

    public decimal taxable_medicare_wages_tips{get;set;}
    public decimal medicare_tax{get;set;}// after calc

    public decimal taxable_additional_medicare_wages_tips{get;set;}
    public decimal additional_medicare_tax{get;set;}//after calc
    
    public decimal total_social_security_medicare_tas{get;set;}



}