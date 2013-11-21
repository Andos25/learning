#!/bin/bash 

ROOT_UID=0

#检测是否以超级权限运行
#if [ "$UID" -ne "$ROOT_UID" ]
#then
#    sudo su
#    tar zxvf httpd-2.4.6.tar.gz
#fi
tar zxvf httpd-2.4.6.tar.gz
cd httpd-2.4.6
sudo ./configure --prefix=/usr/local/apache2/ --enable-proxy --enable-ssl --enable-cgi --enable-rewrite --enable-so --enable-module=so
sudo make
sudo make install
sudo chmod 777 -R /usr/local/apache2
sudo echo "ServerName 0.0.0.0:80" >> /usr/local/apache2/conf/httpd.conf
sudo echo "LoadModule slotmem_shm_module modules/mod_slotmem_shm.so" >> /usr/local/apache2/conf/httpd.conf
sudo /usr/local/apache2/bin/apachectl start
