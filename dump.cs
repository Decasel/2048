class dump{

    private int game_id {set; get;} 
    private int count;
    private int field [4,4];

    void setCount (int c) {
        if (c<0) c = 0;
        count = c;
    }

    public void setField (int x, int y, int val) {
        if (x<0) x = 0;
        if (x>3) x = 3;
        if (y<0) y = 0;
        if (y>3) y = 3;
        field[x,y]=val
    }

    public int getCount(){return count}

    public int getField(int x, int y){
        if (x<0) x = 0;
        if (x>3) x = 3;
        if (y<0) y = 0;
        if (y>3) y = 3;
        return field[x,y];
    }

}

template <typename LT> list<LT> = new List();

list<gth>
}

