using SuperMarket;


Person person = new Customer();
IAuthantication authantication = new Casher();
authantication.Logout();
authantication.Logout3();
authantication.Login();
authantication.Login("Jasser", "123456");
person.SayHi();