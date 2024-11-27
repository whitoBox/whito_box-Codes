# week13_A_11_3.py
# id:202444029
# name:kim yo han

from room import Room2 as room
from room import TimeStamp
import datetime as dt
import os

timeformat = "%Y-%m-%d %H:%M:%S"

mypath = "D:\\202444029\\stuff"

if __name__ == "__main__":
    if not os.path.isdir(mypath):
        os.mkdir(mypath)

    rooms = []
    
    # 파일이 있으면 읽어서 rooms에 복구한다.
    members = os.listdir(mypath)
    for member in members:
        member_fullname = os.path.join(mypth,member)
        if os.path.isfile(member_fullname):
            file_ext = os.path.splitext(member)#return ["file.name.stuff", ".txt"]
            if len(file_ext) == 2 and file_ext[-1] == ".txt":
                number = file_ext[0].strip()
                room = Room(number)
                rooms.append(room)
                #rooms[number] = []
                
                with open(member_fullname, 'r', encoding="utf-8")as f:
                    for line in f: #모든 줄 이렇게 읽을수 있음
                        split_line = line.strip().split('|')
                        if len(split_data) == 2:
                            intime = dt.strptime(split_datas[0].strip(), timeformat)
                            if split_datas[1].strip():
                                outtime = dt.strptime(split_datas[1].strip(), timeformat)
                            else:
                                outtime = None
                            room.add_timestamp(intime,outtime)
            


    while True:
        room = input("강의실 호수:").strip()
        if not room:
            break
        #아래 이거 0(없음),1(있음) 이거 외에 값 나오면 프로그램 잘못 만든거임
        search_room = [room_info for room_info in rooms if room_info.number == room]
        
        if not search_room:
            room_info = Room(room)
            rooms.append(room_info)
        else:
            room_info = search_room[0]
            for timestamp in room_info.history:
                if timestamp.is_rent():
                    #반납(퇴실) 코드 작성해보기
                    print("대여중입니다 떠나세요")
                    continue

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

        #rent_info = {"in": starttime, "out": stoptime}
        #rooms[room].append(rent_info)
        room_info.add_timestamp(starttime,stoptime)
        
        fullfile = os.join.path(mypath, room+".txt")

        with open(fullfile, 'a', encoding = 'utf-8') as f:
            intime = dt.strftime(starttime,timeformat)
            if not stoptime == None:
                outtime = dt.strftime(stoptime,timeformat)
                f.write(f"{intime}|{outtime}\n")
            else:
                f.write(f"{intime}|")
                #
        
    for room_info in rooms:
        print(room_info)
        for timestamp in room_info.history:
            print(timestamp.intime, timestamp.outtime)
            print(timestamp.diff_seconds())

    
