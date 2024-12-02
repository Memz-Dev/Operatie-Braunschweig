import React, { useState } from 'react';
import './page.css';
const OptionsPage = () => {
    return(
        <div className='OptionsPage'>
            <h2 className='Options'>Opties</h2>
            <div className="flex-container">
                <div><button className="block">
                    Account instellingen
                </button></div>
                <div><button className="block">
                    Abonnement instellingen
                </button></div>
                <div><button className="block">
                    tbd instellingen
                </button>
                </div>
            </div>
            <div className="floatingPage options" id="optionsFP">
                    Hier moet de Tekst
            </div>
        </div>
    )
}
export default OptionsPage;