import React from 'react';
import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom';

// Import your components (pages)
import HomePage from "./Pages/Home";
import SignUpPage from './Pages/SignUp';
import LoginPage from './Pages/Login';

import Navbar from './Components/Navbar'; // Make sure Navbar is imported correctly

function App() {
    

    return (
        <Router>
            <div className="WebsiteBody"> 
                <Navbar/>
                <div>
                    <Routes>
                        <Route path="/" element={<HomePage />} />
                        <Route path="/signup" element={<SignUpPage />} />
                        <Route path="/login" element={<LoginPage />}/>
                    </Routes>
                </div>
            </div>
        </Router>
    );
}

export default App;
