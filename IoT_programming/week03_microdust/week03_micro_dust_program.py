import serial
from influxdb_client import InfluxDBClient
import time

serial_port = 'COM6'
baud_rate = 9600
timeout = 2

influxdb_url = "http://localhost:8086"
influxdb_token = "uWlwUcZyjlSU6o-r4WFe5v4SBXODk8IgI-X60QgQWorwwum3NCQnlbssxv3UkrchRBTjEVI1Kq-yqIBqtRv9zw=="
influxdb_org = "test"
influxdb_bucket = "dust"

client = InfluxDBClient(url=influxdb_url, token=influxdb_token, org=influxdb_org)
write_api = client.write_api()

try:
    ser = serial.Serial(serial_port, baud_rate, timeout = timeout)
    print(f"Connected to {serial_port} at {baud_rate} baud")
except Exception as e:
    print("Failed to connect to serial port")
    print(e)
    exit()

try:
    while True:
        if ser.in_waiting > 0:
            line = ser.readline().decode('utf-8').strip()

            if "=" in line:
                key, value = line.split("=")
                try:
                    value = float(value)
                    data=f"sensor_data,device=arduino {key}={value}"
                    write_api.write(bucket=influxdb_bucket, record=data)
                    print(f"Data Written to influxDB: {key}={value}")
                except ValueError:
                    print("Invalid data format")
        time.sleep(1)
except KeyboardInterrupt:
    print("프로그램이 종료되었습니다.")

finally:
    ser.close()
