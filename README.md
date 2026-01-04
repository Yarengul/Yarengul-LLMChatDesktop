# Yarengul-LLMChatDesktop
LLMChatDesktop
C# ve WinForms kullanılarak geliştirilmiş, Groq API üzerinden Llama 3.3 modeline bağlanan modern bir masaüstü sohbet uygulamasıdır.

Özellikler
Hızlı Yanıt: Groq altyapısı sayesinde yapay zeka yanıtlarını milisaniyeler içinde alır.

Kullanıcı Dostu Arayüz: Sade ve anlaşılır WinForms tasarımı.

Asenkron Yapı: API istekleri sırasında uygulama donmaz, akıcı bir deneyim sunar.

Kolay Kurulum: Sadece API anahtarınızı ekleyerek çalıştırabilirsiniz.

Gereksinimler
Visual Studio 2022

.NET 6.0 veya üzeri

Newtonsoft.Json (NuGet paketi)

Groq Cloud API Anahtarı

Kurulum ve Çalıştırma
Bu depoyu klonlayın:

Bash

git clone https://github.com/kullaniciadi/LLMChatDesktop.git
Projeyi Visual Studio ile açın.

Form1.cs dosyasını açın ve apiKey değişkenine kendi Groq API anahtarınızı yapıştırın.

NuGet Paket Yöneticisi Konsolu'nu açın ve gerekli paketi yükleyin:

PowerShell

Install-Package Newtonsoft.Json
Projeyi başlatmak için F5 tuşuna basın.

Kullanılan Teknolojiler
Dil: C#

Framework: .NET / Windows Forms

API: Groq Cloud (Llama-3.3-70b-versatile)

Veri Formatı: JSON

Lisans
Bu proje açık kaynaklıdır ve geliştirme amaçlı kullanılabilir.
