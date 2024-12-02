import React, { useState } from 'react';
import './page.css';

const LoginForm = () => {
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');

    const onSubmit = (e) => {
        e.preventDefault();
        fetch()
    }
    return(
    <div className="Page" style={{ alignItems: 'center' }}>
            <div className='floatingPage'>
                <h2 style={{ textAlign: 'center' }} >Fill out your details</h2>
                <form style={{ textAlign: 'center' }} onSubmit={onSubmit}>
                    <label htmlFor="email">E-Mail</label>
                    <br></br>
                    <input type="email" id="email" name="email" onChange={(e) => setEmail(e.target.value)}></input>
                    <br></br>
                    <label htmlFor="Password">Wachtwoord</label>
                    <br></br>
                    <input type="password" id="wachtwoord" name="wachtwoord" onChange={(e) => setPassword(e.target.value)}></input>
                    <br></br>
                    <br></br>
                    <input type="submit" value="Submit"></input>
                </form>
            </div>   
    </div>
    )
}
function LoginPage() {

    return (

        <div className="FormDiv">
            <h1 style={{ textAlign: 'center' }} >Login</h1>
            <LoginForm />
        </div>

    );
}

export default LoginPage;