import React, { useState } from 'react'; // Add this line
import './Page.css'


// + ChatGpt "Help me write a reactjs input form"
const NameEmailForm = () => {
    
    const [firstName, setFirstName] = useState('');
    const [lastName, setLastName] = useState('');

    const [email, setEmail] = useState('');

    const onSubmit = (e) => {
        e.preventDefault();
        console.log("hello");
    }

    return (
        <div className="Page" style={{ alignItems:'center' }} >
            <h2 style={{textAlign:'center'}} >Fill out your details</h2>
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
                <input type="text" id="email" name="email" onChange={(e) => setEmail(e.target.value)}></input>
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
            <NameEmailForm/>
        </div>
        
    );

}

export default SignUpPage;
