# CSharp_Assignment2_Ankit_kumar

This is a C# ASP.NET Core Web API project for **Assignment 2** created by **Ankit Kumar** for the course taught by **Christine Bittle**.  
The assignment includes solving adapted CCC (Canadian Computing Competition) problems via API endpoints.

---

## 🧠 Project Overview

This Web API includes 5 questions:

| Question | Topic               | Method Type | Route                             |
|----------|--------------------|-------------|-----------------------------------|
| Q1       | Deliv-e-droid      | POST        | `/api/Question1_2/Delivedroid`    |
| Q2       | Hamburger Combo    | GET         | `/api/Question1_2/HamburgerCombo` |
| Q3       | Chili Peppers      | GET         | `/api/Question3_4/ChiliPeppers`   |
| Q4       | Vowel Word Count   | GET         | `/api/Question3_4/VowelWords`     |
| Q5       | Time Palindrome    | GET         | `/api/Question5/IsTimePalindrome` |

---

## ⚙️ Technologies Used

- .NET 8
- ASP.NET Core Web API
- Visual Studio 2022
- Git + GitHub

---

## ▶️ How to Run the API

1. Open the solution in Visual Studio.
2. Press `Ctrl + F5` to run the project.
3. The API will launch in your browser at `http://localhost:5146/swagger`.

---

## 🧪 How to Test the API

### ✅ Using Swagger (Recommended)

- Go to: `http://localhost:5146/swagger`
- Test each endpoint by clicking **“Try it out”**
- Enter required values and click **“Execute”**

### ✅ Using cURL (Alternative)

You can also test using `curl` in command line. Example:

```bash
curl -X POST http://localhost:5146/api/Question1_2/Delivedroid \
-H "Content-Type: application/x-www-form-urlencoded" \
-d "Collisions=2&Deliveries=5"
```
Name: Ankit Kumar
Student ID: N01745787
Course: Web Development
Instructor: Christine Bittle
