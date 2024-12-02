import React, { useState } from 'react'; // Add this line
import './Page.css'


// + ChatGpt "Help me write a reactjs input form"
const SignupForm = () => {
    
    const [firstName, setFirstName] = useState('');
    const [lastName, setLastName] = useState('');
    const [email, setEmail] = useState('');
    const [adres, setAdres] = useState('');
    const [phoneNumber, setPhoneNumber] = useState('');
    const [password, setPassword] = useState('');

    const onSubmit = (e) => {
        e.preventDefault();
        const data = {
            Naam: firstName + " " + lastName,
            EmailAdres: email,
            Adres: adres,
            Telefoonnummer: phoneNumber,
            Wachtwoord: password
        };
        fetch('https://localhost:5126/api/account/create-huurdersaccount',{
            method: 'POST', headers: { 'Content-type': 'application/json' }, body: JSON.stringify(data)
        }).then(response => response.json())
            .then(data => console.log('Success:', data))
            .catch((error) => console.error('Error:', error));
        
    }

    return (
        <div className="Page" style={{ alignItems:'center' }}>
            <h2 style={{textAlign:'center'}} >Vul hier je accountdetails in</h2>
            <form onSubmit={onSubmit}>
                <label htmlFor="firstName">Voornaam</label>
                <br></br>
                <input type="text" id="firstName" name="firstName" onChange={(e) => setFirstName(e.target.value)}></input>
                <br></br>
                <br></br>

                <label htmlFor="lastName">Achternaam</label>
                <br></br>
                <input type="text" id="lastName" name="lastName" onChange={(e) => setLastName(e.target.value)}></input>
                <br></br>
                <br></br>

                <label htmlFor="email">E-Mail</label>
                <br></br>
                <input type="email" id="email" name="email" onChange={(e) => setEmail(e.target.value)}></input>
                <br></br>
                <br></br>

                <label htmlFor="adress">Adres</label>
                <br></br>
                <input type="text" id="adres" name="adres" onChange={(e) => setAdres(e.target.value)}></input>
                <br></br>
                <br></br>

                <label htmlFor="PhoneNumber">Telefoonnummer</label>
                <br></br>
                <input type="number" id="telefoonnummer" name="telefoonnummer" onChange={(e) => setPhoneNumber(e.target.value)}></input>
                <br></br>
                <br></br>

                <label htmlFor="Password">Wachtwoord</label>
                <br></br>
                <input type="password" id="wachtwoord" name="wachtwoord" onChange={(e) => setPassword(e.target.value)}></input>
                <br></br>
                <br></br>
                <input type="submit" value="Submit"></input>
            </form>
        </div>
    );
};

function SignUpPage() {

    return (

        <div className = "FormDiv">
            <h1>Sign Up</h1>
            <SignupForm/>
        </div>
        
    );

}

export default SignUpPage;
