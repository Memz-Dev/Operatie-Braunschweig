//import React, { useState } from 'react';
////ChatGpt: pas de logica van de SignUp toe op de Bedrijf Formulier

//const BedrijfForm = () => {
//    const [formData, setFormData] = useState({
//        bedrijfsnaam: '',
//        adres: '',
//        kvkNummer: '',
//    });

//    const handleChange = (e) => {
//        const { name, value } = e.target;
//        setFormData({
//            ...formData,
//            [name]: value,
//        });
//    };

//    const handleSubmit = (e) => {
//        e.preventDefault();

//        // De API-endpoint waar je gegevens naartoe wilt sturen
//        fetch('http://localhost:5000/api/Account/create-bedrijfsaccount', {
//            method: 'POST',
//            headers: {
//                'Content-Type': 'application/json',
//            },
//            body: JSON.stringify(formData), // Zet de formData om naar JSON
//        })
//            .then((response) => {
//                if (!response.ok) {
//                    throw new Error('Failed to create bedrijfsaccount');
//                }
//                return response.json();
//            })
//            .then((data) => {
//                console.log('Success:', data);
//                alert('Bedrijfsaccount succesvol aangemaakt!');
//            })
//            .catch((error) => {
//                console.error('Error:', error);
//                alert('Er is iets misgegaan bij het aanmaken van het bedrijfsaccount.');
//            });
//    };


//    return (
//        <div className="Page">
//            <h2>Zakelijk Abonnement Aanvragen</h2>
//            <form onSubmit={handleSubmit}>
//                <label htmlFor="bedrijfsnaam">Bedrijfsnaam:</label>
//                <input
//                    type="text"
//                    id="bedrijfsnaam"
//                    name="bedrijfsnaam"
//                    value={formData.bedrijfsnaam}
//                    onChange={handleChange}
//                />
//                <br />
//                <label htmlFor="adres">Adres:</label>
//                <input
//                    type="text"
//                    id="adres"
//                    name="adres"
//                    value={formData.adres}
//                    onChange={handleChange}
//                />
//                <br />
//                <label htmlFor="kvkNummer">KVK-nummer:</label>
//                <input
//                    type="text"
//                    id="kvkNummer"
//                    name="kvkNummer"
//                    value={formData.kvkNummer}
//                    onChange={handleChange}
//                />
//                <br />
//                <button type="submit">Verstuur</button>
//            </form>
//        </div>
//    );
//};

//export default BedrijfForm;
