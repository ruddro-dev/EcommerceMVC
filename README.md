
# Full-Stack E-commerce Application using ASP.NET Core MVC

This is a comprehensive E-commerce application built using ASP.NET Core MVC. It provides a robust platform for customers and administrators with features such as role-based authorization, product browsing, cart management, order handling, payment integration, and external login functionality. The application is designed for scalability, responsiveness, and ease of use.



## Setup Instructions

Clone the Repository:

```bash
  https://github.com/ruddro-dev/EcommerceMVC.git
```

Configure the App:

```bash
{
  "Stripe": {
    "PublishableKey": "your-publishable-key",
    "SecretKey": "your-secret-key"
  },
  "Authentication": {
    "Facebook": {
      "AppId": "your-app-id",
      "AppSecret": "your-app-secret"
    }
  }
}
```
Database Migration:

```bash
dotnet ef database update
```
Run the Application:

```bash
dotnet run
```
Access the Application:

```bash
https://localhost:5001.
```
## Screenshots

Home page (_Layout):

![Screenshot (48)](https://github.com/user-attachments/assets/72b68f20-9810-4093-8436-55a3a286853f)


Login page:

![Screenshot (49)](https://github.com/user-attachments/assets/c977de30-92e5-4e3f-b2c0-9187192c4116)


Register page:

![Screenshot (50)](https://github.com/user-attachments/assets/acf26010-f238-4969-8870-b13533bc0179)


Login with Facebook:

![Screenshot (60)](https://github.com/user-attachments/assets/f0b56fd0-e644-4709-bfba-6671fc14db3a)

Create categories:

![Screenshot (51)](https://github.com/user-attachments/assets/b5665d75-9943-4abd-9206-396f8fa64345)


Create products and filtering:

![Screenshot (52)](https://github.com/user-attachments/assets/375ebde2-9ac7-4731-b424-f1e4e9dc7491)


Company creation and listing with filtering:

![Screenshot (53)](https://github.com/user-attachments/assets/722a5e06-5d15-4c66-ae20-620e458c131e)


Admin can Register a new user and provide roles:

![Screenshot (54)](https://github.com/user-attachments/assets/92f2fcba-5864-43c2-bd22-7a8225450776)


Product details page:

![Screenshot (55)](https://github.com/user-attachments/assets/fd5adc57-51cb-4d88-b367-2e029b07b1cb)


Shopping cart:

![Screenshot (56)](https://github.com/user-attachments/assets/8c0afe14-ddbe-4de1-9d60-683b9feb3e1e)


Order summary:

![Screenshot (57)](https://github.com/user-attachments/assets/96f5ddad-5633-4c25-9b40-d78bca5b22ed)


Stripe payment:

![Screenshot (58)](https://github.com/user-attachments/assets/95bd5d87-4011-4906-9254-d6548ff00446)


Order confirmation page:

![Screenshot (59)](https://github.com/user-attachments/assets/0d0786d1-e9ae-40b5-a642-e430f7647d54)




