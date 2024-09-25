FROM bogem/ftp

# Create the uploads directory inside the container
RUN mkdir -p /var/ftp/uploads

# Set permissions to allow writing to the uploads directory
RUN chmod 755 /var/ftp/uploads

# Environment variables for FTP server configuration
ENV FTP_USER=anonymous \
    FTP_PASS=anonymous \
    FTP_PUBLIC=true

# Expose FTP ports
EXPOSE 21 20
