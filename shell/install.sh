#!/bin/bash 

ROOT_UID=0

tar zxvf httpd-2.2.26.tar.gz
cd httpd-2.2.26
sudo ./configure --prefix=/usr/local/apache2/ --enable-proxy --enable-ssl --enable-cgi --enable-rewrite --enable-so --enable-module=so
sudo make
sudo make install
sudo chmod 777 -R /usr/local/apache2
sudo echo "ServerName 0.0.0.0:80" >> /usr/local/apache2/conf/httpd.conf
sudo echo "AddType application/x-httpd-php .php" >> /usr/local/apache2/conf/httpd.conf
sudo echo "Include conf/extra/httpd-ssl.conf"
mkdir /usr/local/apache2/ssl
sudo openssl req -x509 -nodes -days 365 -newkey rsa:2048 -keyout /usr/local/apache2/ssl/apache.key -out /usr/local/apache2/ssl/apache.crt
sudo echo "SSLCertificateFile \"/usr/local/apache2/ssl/apache.crt\"">>/usr/local/apache2/conf/extra/httpd-ssl.conf
sudo echo "SSLCertificateKeyFile \"/usr/local/apache2/ssl/apache.key\"">>/usr/local/apache2/conf/extra/httpd-ssl.conf
sudo /usr/local/apache2/bin/apachectl start
sudo apt-get install python-dev
exit
cd ../
tar zxvf libxml2-2.9.1.tar.gz 
cd libxml2-2.9.1
sudo ./configure --prefix=/usr/local/libxml2 
sudo make
sudo make install

cd ../
tar jxvf php-5.5.6.tar.bz2
cd php-5.5.6
sudo ./configure --prefix=/usr/local/php --with-libxml-dir=/usr/local/libxml2 --with-apxs2=/usr/local/apache2/bin/apxs
sudo make
sudo make install
sudo ln -s /usr/local/php/bin/php /usr/bin/php
sudo /usr/local/apache2/bin/apachectl restart
