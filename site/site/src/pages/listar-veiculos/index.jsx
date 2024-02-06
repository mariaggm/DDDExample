import React from 'react';
import {useState, useEffect } from 'react'

function Index() {
    const [veiculo, setVeiculos] = useState([]);

    async function getVeiculos() {
        try {
            const response = await fetch('https://localhost:7299/api/Veiculo/Veiculos-Disponiveis')
            const data = await response.json();
            console.log(data);
            setVeiculos(data);
        }
        catch (error) {
            console.erro("erro ao obter veiculos", error);
        }
    }

    useEffect(() => {
        getVeiculos();
    }, []);

    return (
        <div className="veiculos-container">
            {
                veiculo.map(veiculo => (
                    <div key={veiculo.id} className="card">
                        <img src={veiculo.imagem} alt={'Veiculo ${veiculo.tipoVeiculo}'} />
                        <br />
                        <div className="card-content">
                            <p>Tipo Veiculo: {veiculo.tipoVeiculo}</p>
                            <p>Estado: {veiculo.estado}</p>
                            <p>Ano: {veiculo.anoFrabricao}</p>
                            <p>Placa: {veiculo.placa}</p>
                        </div>
                    </div>

                ))
            }

        </div>

    );



    
  
  
}

export default Index;