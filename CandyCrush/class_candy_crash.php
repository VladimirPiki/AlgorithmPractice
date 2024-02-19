<?php


class CandyCrash{
    
    public function howLong($times,$position){

        $cistaBrojka=implode(",",$times);
        #echo $cistaBrojka;
        $dolzinaNiza=count($times);
        $maxDesno=0;
        $maxLevo=0;
        $distanca=1;
        $candy=$times[$position];
        $max=0;


        if ($position < $dolzinaNiza){
   
            for($i=$position + 1; $i < $dolzinaNiza; $i++){

                $novIndex=$times[$i];
     
                if($novIndex > $distanca){

                    if($novIndex > $maxDesno){

                        $maxDesno=$novIndex;

                    }
                    $distanca++;


                }else break;
            }     
        }

        $distanca=1;

        if($position > 1){
           
            for ($i = $position - 1 ; $i >= 0; $i--){
                
                $novIndex=$times[$i];

                if($novIndex > $distanca){

                    if($novIndex > $maxLevo){
                        $maxLevo=$novIndex;
                    }
                    $distanca++;
                } else break;    
            }
        }
        if($maxDesno > $maxLevo){
            $max = $maxDesno;
        }else $max = $maxLevo;
        if($candy > $max){
            $max=$candy;
        }

        return $candy;
        echo "$candy";
        
    }
}       
?>