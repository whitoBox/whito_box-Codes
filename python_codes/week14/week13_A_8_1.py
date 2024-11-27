# week13_A_8_2.py
# id:20240000
# name:jang eunmee
import datetime as dt
import os

timeformat = "%Y-%m-%d %H:%M:%S"

mypath = "c:\\room1_2400001"
myfile = "list.txt"
fullfile = os.path.join(mypath, myfile)


def diff_seconds(intime, outtime):
    if not outtime:
        outtime = dt.datetime.now()
    return (outtime - intime).total_seconds()


if __name__ == "__main__":
    if not os.path.isdir(mypath):
        os.mkdir(mypath)

    rooms = []

    # 파일이 있으면 읽어서 rooms에 복구한다.

    while True:
        room = input("강의실 호수:").strip()
        if not room:
            break

        while True:
            try:
                starttime = input("시작시간:").strip()
                if starttime:
                    starttime = dt.datetime.strptime(starttime, timeformat)
                    break
            except:
                pass

        while True:
            try:
                stoptime = input("종료시간:").strip()
                if not stoptime:
                    stoptime = None
                else:
                    stoptime = dt.datetime.strptime(stoptime, timeformat)
                break
            except:
                pass

        room_info = {"num": room, "in": starttime, "out": stoptime}
        rooms.append(room_info)

    for room in rooms:
        print(room["num"], room["in"], room["out"])
        print(diff_seconds(room["in"], room["out"]))

    with open(fullfile, "w", encoding="utf-8") as f:
        for room in rooms:
            num = room["num"]
            starttime = dt.datetime.strftime(room["in"], timeformat)
            if not room["out"]:
                stoptime = ""
            else:
                stoptime = dt.datetime.strftime(room["out"], timeformat)

            f.write(f"{num}|{starttime}|{stoptime}\n")
