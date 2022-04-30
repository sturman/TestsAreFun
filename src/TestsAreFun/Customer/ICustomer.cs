﻿namespace TestsAreFun.Customer;

public interface ICustomer
{
    string FirstName { get; set; }

    IPhoneNumber PhoneNumber { get; set; }
    IList<IOrder> Orders { get; set; }

    int GetAge();
}