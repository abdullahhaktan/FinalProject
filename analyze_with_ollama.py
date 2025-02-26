import json
import requests  # requests modülünü tam olarak import et
import time

# JSON verisini yükleyin
with open('data.json', 'r', encoding='utf-8') as file:
    data = json.load(file)

# Ollama API URL'si
url = "http://localhost:11434/api/generate"  # Doğru endpoint

# JSON veri formatında prompt gönderme
def send_to_ollama(message):
    start_time = time.time()

    # İstek için prompt
    prompt = f"""
    Bu JSON verisini analiz et:
    {json.dumps(message, indent=4, ensure_ascii=False)}

    - Yaş ortalamasını hesapla.
    - "Teknoloji" ile ilgilenen kullanıcıları listele.
    - En genç ve en yaşlı kullanıcıları belirt.
    - Lokasyona göre kullanıcı sayısını grupla.
    """

    data = {
        "model": "llama3.1",
        "prompt": prompt
    }

    try:
        response = requests.post(url, json=data)

        if response.status_code == 200:
            print("Ollama'nın Yanıtı: ")
            print(response.text)  # Ham yanıtı yazdır
        else:
            print(f"Hata: {response.status_code}, {response.text}")

    except Exception as e:
        print(f"Ollama'ya istek gönderme hatası: {e}")

    print(f"Yanıt süresi: {time.time() - start_time} saniye")

# Örnek olarak veriyi gönderme
send_to_ollama(data)
