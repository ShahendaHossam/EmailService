# 📧 Email Service
A lightweight, modular Email Sending API built with ASP.NET Core, designed to send emails through SMTP (e.g., Gmail). This service is ideal for microservice-based systems or apps that need a standalone email gateway.

# ✨ Features
✅ Send plain text or HTML-formatted emails
🔐 SMTP config via appsettings.json
🧪 Swagger UI for easy testing
📦 Clean architecture with layered design
🧱 Easily extendable (e.g., templates, attachments, logging)

# 🧠 Architecture
+----------------+        +-------------------+       +-------------------+
|    Controller  |  -->   |  SendEmailManager |  -->  |    SmtpClient     |
+----------------+        +-------------------+       +-------------------+
        API Layer               Application Layer          Infrastructure Layer
        
# ⚙️ Configuration
In your appsettings.json file:

"EmailSettings": {
  "Email": "your-email@gmail.com",
  "Password": "your-app-password",
  "Host": "smtp.gmail.com",
  "Port": 587
}

# ⚠️ If you're using Gmail, enable 2FA and use an App Password.

# 🚀 How to Set Up
1. Clone the Repository
git clone https://github.com/yourusername/EmailService.git
cd EmailService

2. Open in Visual Studio 2022
3. Update SMTP Settings
Modify appsettings.json under the API project with your credentials.

4. Run the Project
Set the API project as the startup project and hit F5.

5. Use Swagger
Go to:
https://localhost:xxxx/swagger
Use the POST /send-email endpoint to test sending emails.

# 📬 Example Request (Swagger)
{
  "receiver": "someone@example.com",
  "subject": "🎉 Welcome!",
  "body": "Hello there,\n\nThanks for signing up.\n\nRegards,\nEmail Team"
}

# 🧩 Future Improvements (Optional)
📎 Add support for file attachments

# 🔁 Retry logic and queue-based sending

📊 Logging to database or file

🙋‍♀️ Questions or Contributions?
Feel free to open an issue or submit a PR!

