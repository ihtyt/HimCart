# HimCart-Desktop - Apple Orchard Management System

## 🍎 Overview
HimCart-Desktop is a modern WPF desktop application designed for managing apple orchards in Himachal Pradesh. The application provides tools for production tracking, disease detection, and orchard health monitoring.

## ✨ Features

- ✅ **AI Neural Engine** - Real-time apple detection and counting (YOLOv8)
- ✅ **Disease Analysis** - Pathogenic marker identification on leaf surfaces
- ✅ **Firebase Authentication** - Secure cloud-based user management
- ✅ **VR Orchard Tour** - 360° immersive digital twin view
- ✅ **History Tracking** - Persistent storage of scan results (JSON-based)
- ✅ **Offline-First Ready** - Local AI inference and local history storage
- ✅ **Modern Dark UI** - High-contrast "Dark Fern" aesthetic with glassmorphism

## 🛠️ Technology Stack

- **Framework**: .NET 8.0 (WPF)
- **AI/ML**: ONNX Runtime + Emgu.CV (YOLOv8 Inference)
- **Navigation**: MVVM (CommunityToolkit.Mvvm)
- **Database**: JSON-based Flat File System (LiteDB removed for speed)
- **3D/VR**: Three.js integrated via WebView2
- **Authentication**: Firebase Identity Platform

## 📋 Prerequisites

- Windows 10/11
- .NET 8.0 SDK or Runtime
- Visual Studio 2022 (for development)
- Internet connection (for Firebase authentication)

## 🚀 Getting Started

### Installation

1. Clone the repository
2. Open `HimCart-Desktop.sln` in Visual Studio 2022
3. Restore NuGet packages
4. Build and run the application

### First Run

1. Launch the application
2. Click "Create one" to register a new account
3. Enter your email and password (min 6 characters)
4. Login with your credentials
5. Explore the dashboard

## 🔐 Security Notes

⚠️ **Important**: The Firebase API key is currently hardcoded for development purposes. For production:
1. Move the API key to `app.config` or environment variables
2. Enable Firebase security rules
3. Implement proper key rotation

## 📁 Project Structure

```
HimCart-Desktop/
├── Services/              # Business logic and services
│   ├── IAuthenticationService.cs
│   └── FirebaseAuthService.cs
├── View/                  # UI Views
│   ├── MainLogin.xaml/cs
│   ├── CreateAccountDialog.xaml/cs
│   └── DashboardView.xaml/cs
├── Styles/                # UI Styles and themes
│   └── UIColorInterface.xaml
├── Assets/                # Images, logos, datasets
└── App.xaml/cs           # Application entry point
```

## 🎨 UI/UX Features

- **Smooth Animations** - Fade-in effects and shake animations
- **Password Toggle** - Show/hide password functionality
- **Loading States** - Visual feedback during operations
- **Input Validation** - Real-time validation with helpful messages
- **Responsive Design** - Adapts to different window sizes

## 🐛 Known Issues

- HEIC image format not natively supported in WPF (convert to JPG/PNG)
- Token refresh not yet implemented (tokens expire after 1 hour)
- Google OAuth not implemented

## 🔄 Recent Improvements

### Code Quality
- ✅ Enhanced error handling with detailed logging
- ✅ Added email validation
- ✅ Implemented password strength checking
- ✅ Better null handling for .NET 8
- ✅ Token expiry tracking
- ✅ Renamed project from AlphaX to HimCart-Desktop

### User Experience
- ✅ Loading states with visual feedback
- ✅ Better error messages
- ✅ Input validation with focus management
- ✅ Dynamic dashboard content
- ✅ Stat cards for quick overview

### Performance
- ✅ Removed hardcoded absolute paths
- ✅ Cleaned up orphaned file references
- ✅ Optimized authentication flow

## 📝 Development Roadmap

### Phase 1: Engine Stabilization ✅
- [x] Optimized build pipeline (Cleaned 500MB+ junk assets)
- [x] Integrated real-time vision services
- [x] Implemented global exception handling

### Phase 2: Analytics & Scale (Upcoming)
- [ ] Export reports to CSV/PDF
- [ ] Dynamic production trend charts
- [ ] Cloud sync for scan history

## 🤝 Contributing

This is a private project for orchard management in Himachal Pradesh. For questions or suggestions, contact the development team.

## 📄 License

Proprietary - All rights reserved

## 📞 Support

For technical support or feature requests, please contact the development team.

---

**Version**: 1.0.4  
**Last Updated**: February 15, 2026  
**Platform**: Windows Desktop (WPF)  
**Project Name**: HimCart-Desktop
