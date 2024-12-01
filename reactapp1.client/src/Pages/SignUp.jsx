import React, { useState } from 'react'; // Add this line
import './Page.css'
import './SignUp.css'

// + ChatGpt "Help me write a reactjs input form"
const SignupForm = () => {
    
    const [firstName, setFirstName] = useState('');
    const [lastName, setLastName] = useState('');
    const [email, setEmail] = useState('');
    const [adres, setAdres] = useState('');
    const [phoneNumber, setPhoneNumber] = useState('');
    const [password, setPassword] = useState('');

    const [signupType,setSignupType] = useState('Particulier')

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

    const ParticulierSignUp = () => {
        return (
            <div>
                <h2 style={{ textAlign: 'center' }} >Fill out your details</h2>
                <form className='Form' onSubmit={onSubmit}>
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
    }

    const ZakelijkSelection = () => {
        return (
            <div>
                <div style={{ display: 'flex', justifyContent:'center' }}>
                    <h3 className='ZakelijkeHuurdersType'>
                        Zakelijke Huurder
                    </h3>
                    <h3 className='ZakelijkeHuurdersType'>
                        Medewerker
                    </h3>
                </div>
            </div>
        );
    }

    const onParticulier = (e) => {
        setSignupType('Particulier')
    }
    const onZakelijk = (e) => {
        setSignupType('Zakelijk')
    }

    return (
  
        <div className="Page" style={{ alignItems: 'center' }}>

            <div
                className='floatingPage'
            >

                <div style={{ textAlign: 'center' , justifyContent: 'center' }}>
                    <button
                        onClick={onParticulier}
                        className={signupType === "Particulier" ? "FormTypeButtonSelected" :  "FormTypeButton"}
                    >
                        Particulier
                    </button>
                    <button
                        onClick={onZakelijk}
                        className={signupType === "Zakelijk" ? "FormTypeButtonSelected" : "FormTypeButton"}
                    >
                        Zakelijk
                    </button>
                </div>

                {signupType === "Particulier" ? <ParticulierSignUp/> : signupType === "Zakelijk" ? <ZakelijkSelection/> : null}

            </div>

            
        </div>
    );
}


function SignUpPage() {
    return (
        <div className="FormDiv">
            <h1 style={{ textAlign: 'center' }} >Sign Up</h1>
            <SignupForm />
        </div>
    );

}
export default SignUpPage;

