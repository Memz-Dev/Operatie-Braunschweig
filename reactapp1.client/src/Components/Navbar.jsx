import React from 'react';
import { Link } from 'react-router-dom';

import './Navbar.css';

function Navbar() {
    return (
        <div className = "navbar">
            <h1 className="topText">CarAndAll</h1>

            <div className = "holderDiv">
                <ul className="itemList">
                    <li className="buttonHolder">
                        <Link to="/"><b>Home</b></Link>
                    </li>
                    <li className="optionsButton">
                    <Link to="/options"><b> Options</b></Link>
                    </li>
                    <li className="Signup">
                        <Link to="/signup"><b>Sign Up</b></Link>
                    </li>
                    <li className="Signup">
                        <Link to="/login"><b>Login</b></Link>
                    </li>
                </ul>
            </div>
            
        </div>
    );
}

export default Navbar;