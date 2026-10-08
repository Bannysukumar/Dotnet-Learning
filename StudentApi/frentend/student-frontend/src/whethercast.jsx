import { useEffect, useState } from "react";
import "./whethercast.css";
function Whethercast() {
    const api = "http://localhost:5264/WeatherForecast";
    const [data, setData] = useState([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState("");
    const [selectedDate, setSelectedDate] = useState("");
    useEffect(() => {
        let active = true;

        fetch(api)
            .then((response) => {
                if (!response.ok) throw new Error(`Request failed (${response.status})`);
                return response.json();
            })
            .then((forecasts) => {
                if (active) {
                    setData(forecasts);
                    setSelectedDate(forecasts[0]?.date ?? "");
                }
            })
            .catch((error) => {
                if (active) setError(error.message || "Could not load weather data.");
            })
            .finally(() => {
                if (active) setLoading(false);
            });

        return () => {
            active = false;
        };
    }, []);

    const selectedForecast = data.find((forecast) => forecast.date === selectedDate);

    return (
        <main className="weathercast">
            <h1>Weather Forecast</h1>
            {loading ? (
                <p>Loading weather data...</p>
            ) : error ? (
                <p role="alert">{error}</p>
            ) : data.length === 0 ? (
                <p>No forecast data available.</p>
            ) : (
                <div>
                    <label htmlFor="date-select">Select date</label>
                    <select
                        id="date-select"
                        value={selectedDate}
                        onChange={(event) => setSelectedDate(event.target.value)}
                    >
                        {data.map((forecast) => (
                            <option key={forecast.date} value={forecast.date}>
                                {forecast.date}
                            </option>
                        ))}
                    </select>
                    {selectedForecast && (
                        <article className="selected">
                            <h2>{selectedForecast.date}</h2>
                            <p>Temperature: {selectedForecast.temperatureC}°C / {selectedForecast.temperatureF}°F</p>
                            <p>Conditions: {selectedForecast.summary}</p>
                        </article>
                    )}
                </div>
            )}
        </main>
    );
}

export default Whethercast;
